<!-- <?php #require 'header.php';
//  if(!isset($_GET['var'])){
//         $m=$_GET['mens'];
// }else{
//         $m=$_GET['var'];
// };
?>
<div class="contenedor T" id="con">


               

                <div class="informacionp">     
                        <form action="">            
                        <?# require 'auxEnviarAlumno.php'; ?>
                        </form>
                                
                </div>
</div>
<div style="float: left; width: 100%">
<?php  #include 'footer.php'; ?>
</div>
</body>
</html> -->


<div class="contenedor T" id="con">
        
        <?php require 'header.php';
        
        if(!isset($_GET['var'])){
                $m=$_GET['mens'];
            }else{
                $m=$_GET['var'];
            }
        ?>
        <div class="informacionp">
                <form action="#" method="POST" enctype="multipart/form-data">
                        <?php require 'auxEnviarAlumno.php'; ?>
                </form>
                
        </div>
        
        
      
        
</div>
<?php #require 'footer.php' ?>
</body>
</html>