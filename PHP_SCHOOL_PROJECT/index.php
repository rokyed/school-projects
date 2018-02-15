<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="school.css" />
        <title></title>
    </head>
    <body>
        <center>
        <?php include 'header.php';?>
        <p>
<?php
    error_reporting(E_ALL);
    ini_set("display_errors", "1");
    ini_set('display_startup_errors', "1");
    include 'connection.php';
     session_start();
    
   // if(empty($_SESSION['uid'])){
        if((isset($_POST['login'])?$_POST['login']:FALSE)){
            if(!empty($_POST['user']) && !empty($_POST['pass'])){
                $usr = htmlspecialchars($_POST['user']);
                $pass = htmlspecialchars($_POST['pass']);
                $con = makeConnection();
                $s_usr = mysqli_real_escape_string($con,$usr);
                $s_pass = mysqli_real_escape_string($con,$pass);
                $query ="select * from users where user = '$s_usr' and pass = '$s_pass';";
                $result = mysqli_query($con,$query);
                if(mysqli_num_rows($result) == 1){
                   
                    $row=mysqli_fetch_array($result);
                    $_SESSION['user'] = $row['user'];
                    $_SESSION['pass'] = $row['pass'];
                    $_SESSION['name'] = $row['fullname'];
                    $_SESSION['uid'] = $row['id'];
                    if($row['teacher']=='1'){
                        mysqli_close($con);
                        session_write_close();
                        header('Location : teacher_home.php');
                    }else{
                        mysqli_close($con);
                       session_write_close();
                        header('Location : student_home.php');
                    }
                }else{
                    echo 'Wrong user or password!';
                }
                if(mysqli_ping($con)){
                    mysqli_close($con);
                }
            }else{
                echo 'Please put your user and password!';
            }
         

        }else if((isset($_POST['create'])?$_POST['create']:FALSE)){
            if(!empty($_POST['user']) && !empty($_POST['pass']) && !empty($_POST['name'])&& !empty($_POST['phone'])&& !empty($_POST['email']) ){
                $usr = htmlspecialchars($_POST['user']);
                $pass = htmlspecialchars($_POST['pass']);
                $name = htmlspecialchars($_POST['name']);
                $phone = htmlspecialchars($_POST['phone']); 
                $email = htmlspecialchars($_POST['email']);
                $con = mysqli_connect('localhost','root','laval','school_db') or die('DB!!');
                $s_usr = mysqli_real_escape_string($con,$usr);
                $s_pass = mysqli_real_escape_string($con,$pass);
                $s_name = mysqli_real_escape_string($con,$name);
                $s_phone = mysqli_real_escape_string($con,$phone);
                $s_email = mysqli_real_escape_string($con,$email);
                $query ="select * from users where user = '$s_usr' and pass = '$s_pass';";
                $result = mysqli_query($con,$query);
                if(mysqli_num_rows($result) == 1){
                    echo 'User already exists!';
                }else{
                    $query2 ="insert into users(user,pass,fullname,phone,email,teacher) values ('$s_usr','$s_pass','$s_name','$s_phone','$s_email',0);";
                    $result2 = mysqli_query($con,$query2); 
                    $query3 = "select * from  users where user = '$s_usr' and pass = '$s_pass';";
                    $result3 = mysqli_query($con,$query3);
                    if(mysqli_num_rows($result3) == 1){
                      
                        $row=mysqli_fetch_array($result3);
                        $_SESSION['user'] = $row['user'];
                        $_SESSION['pass'] = $row['pass'];
                        $_SESSION['name'] = $row['name'];
                        $_SESSION['uid'] = $row['id'];
                        mysqli_close($con);
                         session_write_close();
                        header('Location : student_home.php');
                       
                    } else{
                        echo 'Failed retreiving student';
                    }
                }
                if(mysqli_ping($con)){
                    mysqli_close($con);
                }


            }else{
                echo 'Please fill in all the fields!';
            }
        }else{
            echo "Please login , if you don't have an user then create it!";
        }
//}
 

?>
</p>


        <form method="post" action="index.php">
            
                
       <input type="text" placeholder="Username" name="user" value="<?php echo (isset($_POST['user'])?$_POST['user']:'');?>" /><br />
         <input type="password" placeholder="Password" name="pass" value="<?php echo (isset($_POST['pass'])?$_POST['pass']:'');?>" /><br />
         <input type="submit" name="login" value="Login" /><br />
       <input type="text" name="name" placeholder="Your name" value="<?php echo (isset($_POST['name'])?$_POST['name']:'');?>" /><br />
         <input type="text" name="phone" placeholder="Your phone" value="<?php echo (isset($_POST['phone'])?$_POST['phone']:'');?>" /><br />
         <input type="text" name="email" placeholder="Your email"value="<?php echo (isset($_POST['email'])?$_POST['email']:'');?>" /><br />
          <input type="submit"name="create" value="Create" /><br />
        </form>
        </center>
    </body>
</html>
<?php
 
    
?>
