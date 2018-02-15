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
       

?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="school.css" />
        <title>student home</title>
    </head>
    <body><center>
        <?php include 'header.php';?>
        

        <?php 
        $query ="SELECT * FROM courses where id not in (select idcourse from enrolls where iduser ='$userid');";
        $result = mysqli_query($con,$query);
        if(mysqli_num_rows($result)>0){
        ?>
            <form method="post" action="student_home.php">
            <span>Enroll into course:</span><br />
            <select name="listEnroll">
            <?php
            while($row = mysqli_fetch_array($result)){
            ?>
                <option value="<?php echo $row['id'];?>"><?php echo $row['title'].' '.$row['length'];?> </option>
            <?php        
            }
            ?>
            </select>
            <input type="submit" name="add_course" value="Add Course" />
            </form>
        <?php 
            if((isset($_POST['add_course'])?$_POST['add_course']:FALSE) && isset($_POST['listEnroll'])){
                $courseadd= $_POST['listEnroll'];
                $query2 ="insert into enrolls (iduser,idcourse) values ($userid,$courseadd);";
                $result2 = mysqli_query($con,$query2) or die(mysqli_error($con));
                header('Location : student_home.php');
            }else{
                echo 'You had not selected a course to add';
            }     
        }
        ?>
        <table>
            <tr><th>Title</th><th>Length</th></tr>
            <?php
                $query3 ="SELECT * FROM school_db.courses where id in (select idcourse from school_db.enrolls where iduser =$userid) ;";
                 $result3 = mysqli_query($con,$query3) or die(mysqli_error($con));
                 while($row3= mysqli_fetch_array($result3)){
            ?>
              <tr><td><?php echo $row3['title'];?></td><td><?php  echo $row3['length']; ?></td></tr>
            <?php        
            }
            ?>
            </table>
        <p>
            
        <?php
       
        ?>
        </p>
        
        </center>
    </body>
</html>
<?php
    mysqli_close($con);
 }
?>
