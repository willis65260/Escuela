<?php

	$conexion=new mysqli("localhost","root","","calificaciones"); //servidor, usuario de base de datos, contraseña del usuario, nombre de base de datos
	
	if(mysqli_connect_errno()){
		echo 'Conexion Fallida : ', mysqli_connect_error();
		exit();
	}else{
        // echo 'todo bien, todo correcto y yo que me alegro';
    }
?>