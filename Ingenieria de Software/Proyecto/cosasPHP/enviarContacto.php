<?php

$destino="lalop0071999@gmail.com";
$nombre=$_POST["nombre"];
$correo=$_POST["correo"];
$asunto=$_POST["asunto"];
$mensaje=$_POST["mensaje"];

$contenido="Nombre: ".$nombre."\nCorreo: ".$correo."\nAsunto: ".$asunto."\nMensaje: ".$mensaje;

mail($destino,$asunto,$contenido);
header("Formulario.html");

?>