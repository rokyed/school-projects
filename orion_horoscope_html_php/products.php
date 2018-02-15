 <!DOCTYPE html>

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="orion_css.css"/>
        <script type="text/javascript" src="menu_enhacement.js"></script>
        <title></title>
    </head>
    <body>
        <!--Menu starts here-->
            <?php
                include 'menu-bar.php';
                include 'footer-bar.php';
            ?>
         <!--Menu ends here-->
        <center>
             <div class="bar_filler"></div></br>
            <p id="basic_text"> To buy anything call that old lady.</p></br>
                <div id="prods">
                    <center>
                        
                        <table id="productTable">
                           <?php 
                                $queryToDo='select * from products;' ;                      
                                $con =  mysqli_connect('localhost','root','laval','ab_orion') or die('Error connecting to the database.');
                                $result = mysqli_query($con,$queryToDo);
                                ?>
                                <tr>
                                    <th>
                                        Product ID
                                    </th>
                                    <th>
                                        Product Description
                                    </th>
                                    <th>
                                        Price
                                    </th>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        </br>
                                    </td>
                                </tr>
                                <?php
                                while($row = mysqli_fetch_array($result)){
                                ?>
                                    <tr>
                                        <td>
                                            <?php echo $row['productid'] ; ?>
                                        </td>
                                        <td>
                                                <?php echo $row['description'] ; ?>
                                        </td>
                                        <td>
                                               <?php echo $row['price'] ; ?>$
                                        </td>                
                                    </tr>
                                <?php
                                }
                                ?>
                        </table>
                    </center>
                </div>
        </center>
    </body>
</html>
