
<!DOCTYPE html>

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="orion_css.css"/>
        <script type="text/javascript" src="menu_enhacement.js"></script>
         <script type="text/javascript" src="signGenerator.js"></script>
        <title></title>
    </head>
    <body onload="GenerateSigns();">
        <!--Menu starts here-->
              <?php
    include 'menu-bar.php';
    include 'footer-bar.php';
?>
         <!--Menu ends here-->
        <center>
        <div class="bar_filler"></div></br>
        <!--signs-->
        <form method ="post" id="fullform" action="yoursignresult.php">
        <table id="hidden_table">
        <tr>
            <td colspan="2">
                <p>We will tell you more about you , only if you enter your info here!!</p>
            </td>
        </tr>
        <tr>
            <td> 
                Name:
            </td>
            <td> 
                <input class="inputBox" placeholder="Your name here..." id="nameInputX" type="text" name="name">
            </td>
        </tr>
        <tr>
            <td>
               Enter your birth date (yyyy-mm-dd):
            </td>
            <td>
                <input class="inputBox" id="inputBox" name="birth_date"> 
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <input  class="inputButton" type="submit"  value="Find my future!!">
            </td>
        </tr>
        </table>
        </form>
            </br>
            <div id="messageBackX"></div>
            </br><div class="bar_filler"></div></br>
        </center>


    </body>
</html>
