<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>JoseEPT</title>
    <link rel="stylesheet" href="../css/estilo.css">
    <link rel="stylesheet" href="../css//untitled-font-1(1)/styles.css">
    <?php $var="Profesor" ;
          $var2="Alumno"; 
            ?>
</head>

<body>
    <div class="contenedor T" id="con">

        <div class="header T">
            <div class="logo T">
                <!-- <a href="index.html"><img src="img/logo.png" alt="" width="50%"></a> -->
            </div>
            <div class="menu T">
                <ol class="ol_menu">
                    <li class="item-menu"><a href="../index.php?mens=<?php echo $var;?>">Ingresar Profesor</a></li>
                    <li class="item-menu"><a href="../index.php?mens=<?php echo $var2; ?>">Ingresar Alumno</a></li>
                    <!-- <li class="item-menu"><a href="Contenido2.html">Registrar Profesor</a> </li> -->
                    <li class="item-menu"><a href="Formulario.html">Contacto</a></li>
                </ol>
            </div>
            <!-- <span class="icon-menu" id="btn-menu"></span> -->
        </div>
        <form action="enviarContacto.php" method="post" style="position: relative;margin-bottom: 35vh;">
            <h2>Contacto</h2>
            <input type="text" name="nombre" placeholder="Nombre" required>
            <input type="text" name="correo" placeholder="Correo" required>
            <select name="asunto" id="asun" aria-placeholder="Seleccione un asunto">
                <option value="0">seleccione un asunto</option>
                <option value="1">Trabajo</option>
                <option value="2">Contacto</option>
                <option value="3">Personal</option>
            </select>
            <textarea name="mensaje" placeholder="Escriba aqui su mensaje" id="" cols="30" rows="10" required></textarea>
            <input type="submit" value="ENVIAR" id="boton">
        </form>


        <div class="footer" id="aba">
            <div class="social">
                <a href="https://www.facebook.com/manuel.chavez.3994885" class="icon-facebook-square"></a>
                <!-- <a href="https://www.youtube.com/channel/UCuIkjNn7ASW59f5gjMj0-dw?view_as=subscriber" class="icon-youtube"></a> -->
                <a href="https://www.instagram.com/lalop00/?hl=es-la" class="icon-instagram"></a>
                <a href="https://twitter.com/lalop0071999" class="icon-twitter"></a>
            </div>
            <p class="copy">&copy; Jose Eduardo Poo Tapia - Todos los derechos reservados</p>
        </div>
    </div>

</body>

</html>