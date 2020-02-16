<?php
require 'cosasPHP/PHPExcel-1.8/Classes/PHPExcel/IOFactory.php';
# class="forma" style="position:relative;margin-bottom:65vh"
echo '<table border=1><tr><td>noCtrl</td><td>Calificacion</td><td>Materia</td><td>Profesor</td></tr>';
for ($i = 0; $i >=-1 ; $i++) {
        // echo 'simon';
        if(file_exists("cosasPHP/archivos/Calificaciones/$i/")){
                // echo 'simon';
                ComprobarCalificaciones($i,$m);     
        }else{
                echo '<table>';
        break;
}
}


function ComprobarCalificaciones($i,$m){
        include 'cosasPHP/conexion.php';
        // echo 'simon';
        
        for ($k=0; ; $k++) { 
                // echo "es la carpeta $i y va en el archivo $k";
                if(file_exists("cosasPHP/archivos/Calificaciones/$i/$k.xlsx")){
                        
                        
                        ${"objPHPExcel_".$k} = PHPExcel_IOFactory::load("cosasPHP/archivos/Calificaciones/$i/$k.xlsx");
                        
                        ${"objPHPExcel_".$k}->setActiveSheetIndex(0);
                        $numRows = ${"objPHPExcel_".$k}->setActiveSheetIndex(0)->getHighestRow();
                        


                        $sql = "SELECT COUNT(*) FROM alum_prof WHERE id_Alum=$m AND id_Prof=$i";
                        $sentencia = mysqli_stmt_init($conexion);
                        mysqli_stmt_prepare($sentencia, $sql);
                        mysqli_stmt_execute($sentencia);
                        $resultado=mysqli_stmt_get_result($sentencia);
                        // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
                        // $result = $conexion->query($sql);
                        if($busqueda = mysqli_fetch_assoc($resultado))
                        {
                                $cont=$busqueda['COUNT(*)'];
                                // echo $cont;
                                if($cont!=0){
                                        $sql = "SELECT usuario_Alum FROM alumnos where id_Alum=$m";
                        $sentencia = mysqli_stmt_init($conexion);
                        mysqli_stmt_prepare($sentencia, $sql);
                        mysqli_stmt_execute($sentencia);
                        $resultado=mysqli_stmt_get_result($sentencia);
                        // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
                        // $result = $conexion->query($sql);
                        if($busqueda = mysqli_fetch_assoc($resultado))
                        {
                                $usuario=$busqueda['usuario_Alum'];
                                // echo $id;
                        }else{
                                echo 'nelson carnalito';
                        }
                        
                        
                        for ($j=2; $j < $numRows; $j++) { 
                                // echo 'simon';
                                $nCtrl = ${"objPHPExcel_".$k}->getActiveSheet()->getCell('A'.$j)->getCalculatedValue();
                                $calif = ${"objPHPExcel_".$k}->getActiveSheet()->getCell('B'.$j)->getCalculatedValue();
                                $materia = ${"objPHPExcel_".$k}->getActiveSheet()->getCell('C'.$j)->getCalculatedValue();
                                $prof = ${"objPHPExcel_".$k}->getActiveSheet()->getCell('D'.$j)->getCalculatedValue();
                                if($usuario==$nCtrl){
                                        echo '<tr>';
                                        echo '<td>'. $nCtrl.'</td>';
                                        echo '<td>'. $calif.'</td>';
                                        echo '<td>'. $materia.'</td>';
                                        echo '<td>'. $prof.'</td>';
                                        echo '</tr>';
                                }
                        }
                                        
                                }
                                // echo $cont;
                        }else{
                                echo 'nelson carnalito';
                        }
                        
                        
                        
                        
                }else{
                break;
        }
}


}



?>