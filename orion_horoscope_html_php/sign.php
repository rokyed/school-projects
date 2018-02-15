<!DOCTYPE html>

<html lang="en">
   <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="orion_css.css"/>
        <script type="text/javascript" src="menu_enhacement.js"></script>
       <script type="text/javascript" src="signGenerator.js"></script>

        <title></title>
    </head>
    <body onload="GenerateSigns();GenerateSignsMenu('sign_menu_table');GenerateSignsTable('sign_table');">
        <!--Menu starts here-->
              <?php
    include 'menu-bar.php';
    include 'footer-bar.php';
?>
          
         <!--Menu ends here-->
        <center>
        <div id="top_of_page" class="bar_filler"></div> </br>
        <!--signs-->
        <table id="sign_menu_table">
        </table>
            </br>
        <table id="sign_table">
        </table>
            </br>
            <div class="bar_filler"></div> 
        </center>


    </body>
</html>
