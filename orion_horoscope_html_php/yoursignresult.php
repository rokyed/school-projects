<!DOCTYPE html>

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="orion_css.css"/>
        <script type="text/javascript" src="menu_enhacement.js"></script>
         
        <title></title>
    </head>
    <body onload="GenerateSigns();">
        <!--Menu starts here-->    
        <?php
        include 'menu-bar.php';
        include 'footer-bar.php';
        ?>
        <!--Menu ends here-->      
        <div class="bar_filler"></div>
        </br>
        <!--signs-->
        <center>
        <div id="messageBackX">
        <?php       
        $stringtoReturn ='';
        if( isset($_POST['name']) && isset($_POST['birth_date'])){
            $birthDate= htmlspecialchars($_POST['birth_date']);
            $bdx  = explode('-',$birthDate);
            if(count($bdx) ==3){
                if(is_numeric($bdx[0]) && is_numeric($bdx[1])  && is_numeric($bdx[2]) && $bdx[2]>0  && $bdx[1]>0){
                     $intx = intval($bdx[1])*100+intval($bdx[2]);    
                     if($intx<120){
                        $intx+=1200;
                     }   
                    $queryToDo='select * from signs where startOn<='.$intx.' and endOn>='.$intx.';' ;     
                    $con =  mysqli_connect('localhost','root','laval','ab_orion') or die('Error connecting to the database.');
                    $result = mysqli_query($con,$queryToDo);
                    // echo mysqli_error();
                    $row = mysqli_fetch_array($result);
                    ?>        
                    <p id="message_byDate">
                    Hi,<?php echo htmlspecialchars($_POST['name']); ?> 
                    </br>
                    Your sign <?php echo $row['signName']; ?> is at it's best today !! You will live another happy day!!</br>        
                    </br></br></br><img alt="alt" class="signs_image" src="<?php echo $row['imageRef']; ?>"/></br></br></br></p>      
                    <?php
                    mysqli_close($con);
                }else{
                    ?>
                    <p id="message_byDate">The date you entered is wrong,please fix it and try again!!</p>
                    <?php
                   
                }     
            }else{
                ?>
                <p id="message_byDate">The date you entered is wrong,please fix it and try again!!</p>
                <?php
            }
        }else{
        ?>
        <p id="message_byDate">The date you entered is wrong,please fix it and try again!!</p>
        <?php
        }       
        ?>
            
        </div>
        </br>
        <div class="bar_filler"></div>
        </br>
        </center>


    </body>
</html>

  
   
