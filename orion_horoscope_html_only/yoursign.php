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
        <form id="fullform">
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
                <input class="inputBox" placeholder="Your name here..." id="nameInputX" type="text" name="fname">
            </td>
        </tr>
        <tr>
            <td>
                Month of your birthday:
            </td>
            <td>
                <input class="inputBox" id="monthIntX" type="number" value="1" min="1" max="12" step="1" name="month"> 
            </td>
        </tr>
        <tr>
            <td>
                Day of your birthday:
            </td>
            <td>
                <input class="inputBox" id="dayIntX" type="number" value="1" min="1" max="31" step="1" name="day">
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <input  class="inputButton" type="button" onclick="GatherInfo('monthIntX','dayIntX','nameInputX','messageBackX');" value="Find my future!!">
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
