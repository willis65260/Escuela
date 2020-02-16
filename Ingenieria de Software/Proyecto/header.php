<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Calificaciones</title>
    <link rel="stylesheet" href="css/estilo.css">
    <link rel="stylesheet" href="css/styles.css">
    <?php $var="Profesor" ;
          $var2="Alumno"; 
            ?>
</head>
<body>
<div class="header T">
            <div class="logo T">
                <!-- <a href="index.html"><img src="img/logo.png" alt="" width="50%"></a> -->
            </div>
            <div class="menu T">
                <ol class="ol_menu">
                    <li class="item-menu"><a href="index.php?mens=<?php echo $var;?>">Ingresar Profesor</a></li>
                    <li class="item-menu"><a href="index.php?mens=<?php echo $var2; ?>">Ingresar Alumno</a></li>
                    <!-- <li class="item-menu"><a href="Contenido2.html">Registrar Profesor</a> </li> -->
                    <li class="item-menu"><a href="cosasPHP/Formulario.php">Contacto</a></li>
                </ol>
            </div>
            <!-- <span class="icon-menu" id="btn-menu"></span> -->
        </div>

