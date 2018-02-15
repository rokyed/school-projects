

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
        <h1>Queen of Blades School</h1>

        <?php if((isset($_SESSION['uid'])? !empty($_SESSION['uid']):FALSE)){?>
        <h5>Welcome <?php echo $_SESSION['name'] ;?>!</h5>
         <a id="logout" href="logout.php"> 
        <div id="bg_logout">
       
        Log out.</div></a>
        <br /><br /><br />
        <?php }?>
    </body>
</html>
