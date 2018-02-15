<?php
      error_reporting(E_ALL);
    ini_set("display_errors", "1");
    ini_set('display_startup_errors', "1");
    include 'connection.php';
     session_start();
    
    if(empty($_SESSION['uid'])){
         header('Location : index.php');
    }else{

        $userid = $_SESSION['uid'];


       $con = makeConnection();

        if((isset($_GET['del'])?$_GET['del']:'false')=='true'){
            $ctr = $_GET['cid'];
            $query1 ="delete from courses where id=$ctr ;";
            $result1 = mysqli_query($con,$query1) or die(mysqli_error($con));
            mysqli_close($con);
            session_write_close();
            header('Location : teacher_home.php');
        }
        

?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="school.css" />
        <title>Teacher Home!!</title>
    </head>
    <body>
        <center>
             <?php include 'header.php';?>
             
       
               <form method="post" action="teacher_home.php">
                 <input type="text" placeholder="Title" name="title" /><br />
                <input type="number" placeholder="Hours"  min="0" max="999999" name="hours" /><br />
                <input type="submit" name="add_course" value="Add course." />
            </form>
        <p>
        <?php
         if((isset($_POST['add_course'])?$_POST['add_course']:FALSE)){
            if(isset($_POST['hours']) && isset($_POST['title'])){
                if((is_numeric($_POST['hours'])?$_POST['hours']:-100)>=0 ){
                 $hr = htmlspecialchars($_POST['hours']);
                 $title = htmlspecialchars($_POST['title']);
                 $s_hr= mysqli_real_escape_string($con,$hr);
                 $s_title= mysqli_real_escape_string($con,$title);
                 $query2 = "insert into courses(title,length) values ('$s_title',$s_hr);";
                 mysqli_query($con,$query2);
                 mysqli_close($con);
                 session_write_close();
                 header('Location : teacher_home.php');
                }else{
                    echo 'The hours are wrong!';
                }
            }else{
                 echo 'Something is missing!';
            }

        }

        ?>
        </p>
        <table>
            <tr><th>Title</th><th>Length</th><th># students enrolled</th></th><th>Remove Course</th></tr>
            <tr><td colspan="4"><span>Courses with enrolled students.</span></td></tr>
            <?php
                $query3 ="SELECT * FROM school_db.courses where id in (select idcourse from school_db.enrolls) ;";
                 $result3 = mysqli_query($con,$query3) or die(mysqli_error($con));
                 mysqli_close($con);
                 while($row3= mysqli_fetch_array($result3)){
                     $tcon = makeConnection();
                     $cidx= $row3['id'];
                     $tempquery="select count(*) as counted from enrolls where idcourse = $cidx; ";
                     $tresult = mysqli_query($tcon,$tempquery) or die(mysqli_error($tcon));
                     while($trow=mysqli_fetch_array($tresult)){
                   

                   


            ?>
              <tr><td><?php echo $row3['title'];?></td><td><?php  echo $row3['length']; ?></td><td><?php echo $trow['counted'];?></td><td>Not removable!</td></tr>
            <?php  
                     }
               mysqli_close($tcon);
            }
            $con = makeConnection();
            ?>
            <tr><td colspan="4"><span>Courses with no students enrolled.</span></td></tr>
            <?php
            
                $query4 ="SELECT * FROM school_db.courses where id not in (select idcourse from school_db.enrolls) ;";
                 $result4 = mysqli_query($con,$query4) or die(mysqli_error($con));
                 while($row4= mysqli_fetch_array($result4)){
            ?>
              <tr><td><?php echo $row4['title'];?></td><td><?php  echo $row4['length']; ?></td><td>none</td><td><center><form class="rbtn" method="post" action="teacher_home.php?del=true&cid=<?php echo $row4['id'];?>"><input type="submit" name="courseid" value="Remove" /></form></center></td></tr>
            <?php        
            }
            ?>
            </table>
            
         
            </center>
    </body>
</html>
<?php
   mysqli_close($con); 
}
?>
