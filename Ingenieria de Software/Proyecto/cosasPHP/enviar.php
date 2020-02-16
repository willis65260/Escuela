<?php 
include 'conexion.php';

$usuario=$_POST['nombre'];
$contra=$_POST['contra'];
$valor=$_POST['pagina'];

if(isset($_POST['enviar'])){

    if($valor=='Profesor'){
        $sql="SELECT * FROM profesores WHERE usuario_Prof=? AND Contrase_Prof=?;";
    }else if($valor=='Alumno') {
        $sql="SELECT * FROM alumnos WHERE usuario_Alum=? AND contrase_Alum=?;";
    }
    
    $sentencia=mysqli_stmt_init($conexion);
    if(!mysqli_stmt_prepare($sentencia, $sql)){ 
        // Hay un error o podria ser un alumno
        exit();
    }
    else{
        mysqli_stmt_bind_param($sentencia, "ss",$usuario,$contra);
        mysqli_stmt_execute($sentencia);
        $resultado=mysqli_stmt_get_result($sentencia);
        
        if($busqueda = mysqli_fetch_assoc($resultado)){
            // echo $busqueda['usuario_Prof'].'todo bien';
            // Se decide si se va a alumno o a profesor dependiendo del valor de
            // $valor
            $aux=$busqueda['id_Prof'];
            $aux2=$busqueda['id_Alum'];
            if($valor=='Profesor'){
                header("Location: ../enviar".$valor.".php?var=".$aux);
            }else{
                header("Location: ../enviar".$valor.".php?var=".$aux2);
            }
           
        }else{
           // Hay un error
           exit();
        }
    }

}else{
    // Error
    header("Location: ../index.php");
}
?>