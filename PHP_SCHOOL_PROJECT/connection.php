<?php
function makeConnection(){
    $connect = mysqli_connect('localhost','root','laval','school_db') or die('DB!!'); 
    return $connect;
}
?>

