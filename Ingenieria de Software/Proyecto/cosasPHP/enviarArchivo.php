    <?php 
    
    $var=$_POST['var'];
    $asiliar=$_POST['Cambiar'];
    if(isset($_POST['Actualizar'])){
        // echo 'hola';
        // Recibe el nombre y el lugar en el que esta guardado el archivo para poder guardarlo
        $nombre=$_FILES['archivo']['name'];
        $guardado=$_FILES['archivo']['tmp_name'];
        // Revisa si el archivo existe o no
        if(!file_exists("archivos/Usuarios/$var/")){
            // No existe la ruta por lo tanto la crea
            mkdir("archivos/Usuarios/$var/",0777,true);
            if(move_uploaded_file($guardado, "archivos/Usuarios/$var/".$nombre)){
                // Archivo guardado
                // echo $var;
                Actualizar($nombre,$var);
            }else{
                //Archivo no guardado
            }
        }else{
            // Existe la ruta por lo tanto no necesita crearla simplemente sube el archivo
            if(move_uploaded_file($guardado, "archivos/Usuarios/$var/".$nombre)){
                // Archivo guardado
                // echo $var;
                Actualizar($nombre,$var);
            }else{
                //Archivo no guardado
            }
        }
    }
    
    if(isset($_POST['Calificaciones'])){
        echo 'HOLA';
        // Recibe el nombre y el lugar en el que esta guardado el archivo para poder guardarlo
        $nombre=$_FILES['archivoCalif']['name'];
        $guardado=$_FILES['archivoCalif']['tmp_name'];
        // Revisa si el archivo existe o no
        if(!file_exists("archivos/Calificaciones/$var/")){
            // No existe la ruta por lo tanto la crea
            mkdir("archivos/Calificaciones/$var/",0777,true);
            if(move_uploaded_file($guardado, "archivos/Calificaciones/$var/$nombre")){
                // Archivo guardado
                header("Location: ../enviarProfesor.php?var=$var");
                // Actualizar($nombre,$var);
            }else{
                //Archivo no guardado
            }
        }else{
            // Existe la ruta por lo tanto no necesita crearla simplemente sube el archivo
            if(move_uploaded_file($guardado, "archivos/Calificaciones/$var/$nombre")){
                // Archivo guardado
                header("Location: ../enviarProfesor.php?var=$var");
                // Actualizar($nombre,$var);
            }else{
                //Archivo no guardado
            }
        }
    }

    if(isset($_POST['Eliminar'])){
        include 'conexion.php';
        $alum=$_POST['Alumno'];
        header("Location: ../enviarProfesor.php?var=$var");
        
        $sql = "DELETE FROM alum_prof WHERE id_Alum IN (SELECT id_Alum FROM alumnos WHERE usuario_Alum=$alum);";
        $sentencia = mysqli_stmt_init($conexion);
        mysqli_stmt_prepare($sentencia, $sql);
        mysqli_stmt_execute($sentencia);
        $resultado=mysqli_stmt_get_result($sentencia);
        // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
        // $result = $conexion->query($sql);
        if($busqueda = mysqli_fetch_assoc($resultado))
        {
            $id=$busqueda['MAX(id_Alum)']+1;
            // echo $id;
        }else{
            echo 'nelson carnalito';
        }
    }

    if(isset($_POST['Contrase'])){
        include 'conexion.php';
        $alum=$_POST['Alumno'];
        echo 'hola';
        if(isset($_POST['Cambiar'])){
            
            $sql = "UPDATE profesores SET Contrase_Prof=$asiliar WHERE id_Prof=$var";
            $sentencia = mysqli_stmt_init($conexion);
            mysqli_stmt_prepare($sentencia, $sql);
            mysqli_stmt_execute($sentencia);
            $resultado=mysqli_stmt_get_result($sentencia);
            // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
            // $result = $conexion->query($sql);
            header("Location: ../enviarProfesor.php?var=$var");
            
        }
    }
    
    
    
    // if(!file_exists('archivos')){
        //     mkdir('archivos',0777,true);
        //     if(file_exists('archivos')){
            //         // Si el boton presionado es Actualizar entonces Actualiza porque hace referencia a El archivo de alumnos 
            //         if(isset($_POST['Actualizar'])){
                //             $nombre=$_FILES['archivo']['name'];
                //             $guardado=$_FILES['archivo']['tmp_name'];
                
                //             if(move_uploaded_file($guardado, "archivos/Usuarios/$var/".$nombre)){
                    //                 // Archivo guardado
                    //                 Actualizar($nombre,$var);
                    //             }else{
                        //                 //Archivo no guardado
                        
                        //             }
                        //         }else{
                            //             // De otro modo debera añadir un nuevo archivo a las calificaciones
                            //             if(move_uploaded_file($guardado, "archivos/Calificaciones/$var/".$nombre)){
                                //                 $nombre=$_FILES['archivo']['name'];
                                //                 $guardado=$_FILES['archivo']['tmp_name'];
                                //                 Actualizar($nombre,$var);
                                //             }else{
                                    //                 // Archivo no guardado
                                    //             }
                                    //         }
                                    //     }
                                    // }else{
                                        //     if(move_uploaded_file($guardado, 'archivos/'.$nombre)){
                                            //         // Archivo guardado
                                            //         // echo 'entra1';
                                            //         Actualizar($nombre,$var);
                                            //     }else{
                                                //         //Archivo no guardado
                                                //         }
                                                // }
                                                
                                                function Actualizar($nombreArchivo,$var){
                                                    $auxid=0;
                                                    require 'PHPExcel-1.8/Classes/PHPExcel/IOFactory.php'; //Agregamos la librería 
                                                    include 'conexion.php';
                                                    //Variable con el nombre del archivo
                                                    // $nombreArchivo = $nombre;
                                                    // Cargo la hoja de cálculo
                                                    $objPHPExcel = PHPExcel_IOFactory::load("archivos/Usuarios/$var/".$nombreArchivo);
                                                    
                                                    //Asigno la hoja de calculo activa
                                                    $objPHPExcel->setActiveSheetIndex(0);
                                                    //Obtengo el numero de filas del archivo
                                                    $numRows = $objPHPExcel->setActiveSheetIndex(0)->getHighestRow();
                                                    
                                                    echo '<table border=1><tr><td>Producto</td><td>Precio</td></tr>';
                                                    
                                                    for ($i = 2; $i <= $numRows; $i++) {
                                                        // echo $i;
                                                        $nCtrl = $objPHPExcel->getActiveSheet()->getCell('A'.$i)->getCalculatedValue();
                                                        $contra = $objPHPExcel->getActiveSheet()->getCell('B'.$i)->getCalculatedValue();
                                                        
                                                        
                                                        echo '<tr>';
                                                        echo '<td>'. $nCtrl.'</td>';
                                                        echo '<td>'. $contra.'</td>';
                                                        echo '</tr>';
                                                        
                                                        $sql = "SELECT MAX(id_Alum) FROM alumnos";
                                                        $sentencia = mysqli_stmt_init($conexion);
                                                        mysqli_stmt_prepare($sentencia, $sql);
                                                        mysqli_stmt_execute($sentencia);
                                                        $resultado=mysqli_stmt_get_result($sentencia);
                                                        // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
                                                        // $result = $conexion->query($sql);
                                                        if($busqueda = mysqli_fetch_assoc($resultado))
                                                        {
                                                            $id=$busqueda['MAX(id_Alum)']+1;
                                                            // echo $id;
                                                        }else{
                                                            echo 'nelson carnalito';
                                                        }
                                                        
                                                        $sql = "SELECT COUNT(*) FROM alumnos where usuario_Alum='$nCtrl' AND contrase_Alum='$contra'";
                                                        $sentencia = mysqli_stmt_init($conexion);
                                                        mysqli_stmt_prepare($sentencia, $sql);
                                                        mysqli_stmt_execute($sentencia);
                                                        $resultado=mysqli_stmt_get_result($sentencia);
                                                        // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
                                                        // $result = $conexion->query($sql);
                                                        if($busqueda = mysqli_fetch_assoc($resultado))
                                                        {
                                                            $cont=$busqueda['COUNT(*)'];
                                                            if($cont==0){
                                                                $sql = "INSERT INTO alumnos(id_Alum,usuario_Alum,contrase_Alum) VALUES('$id','$nCtrl','$contra');";
                                                                $sentencia = mysqli_stmt_init($conexion);
                                                                mysqli_stmt_prepare($sentencia, $sql);
                                                                mysqli_stmt_execute($sentencia);
                                                                
                                                                $sql = "INSERT INTO alum_prof (id_Prof, id_Alum) VALUES('$var','$id')";
                                                                $sentencia=mysqli_stmt_init($conexion);
                                                                mysqli_stmt_prepare($sentencia, $sql);
                                                                mysqli_stmt_execute($sentencia);
                                                            }
                                                            // echo $cont;
                                                        }else{
                                                            echo 'nelson carnalito';
                                                        }
                                                        
                                                        
                                                        $sql = "SELECT COUNT(*) FROM alum_prof WHERE id_Alum=$auxid AND id_Prof=$var";
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
                                                            if($cont==0){
                                                                $sql = "INSERT INTO alum_prof (id_Prof, id_Alum) VALUES('$var','$auxid')";
                                                                // echo $sql;
                                                                $sentencia=mysqli_stmt_init($conexion);
                                                                mysqli_stmt_prepare($sentencia, $sql);
                                                                mysqli_stmt_execute($sentencia);
                                                                
                                                            }
                                                            // echo $cont;
                                                        }else{
                                                            echo 'nelson carnalito';
                                                        }
                                                        $auxid++;
                                                        
                                                        // $resultado=mysqli_stmt_get_result($sentencia);
                                                        
                                                        
                                                        // $sql = "INSERT INTO productos (nombre, precio, existencia) VALUES('$nombre','$precio','$existencia')";
                                                        // $result = $conexion->query($sql);
                                                        
                                                        
                                                        
                                                        
                                                        // $sql2="SELECT * FROM alumnos WHERE usuario_Alum=$nCtrl AND contrase_Alum=$contra;";
                                                        // $sentencia2=mysqli_stmt_init($conexion);
                                                        // mysqli_stmt_prepare($sentencia2, $sql2);
                                                        // mysqli_stmt_execute($sentencia2);
                                                        // $resultado2=mysqli_stmt_get_result($sentencia2);
                                                        // $busqueda2 = mysqli_fetch_assoc($resultado2);
                                                        // if($busqueda2 = mysqli_fetch_assoc($resultado2)){
                                                            //     echo 'todo bien';
                                                            //     print_r($busqueda2);
                                                            // }else{
                                                                //     echo 'nel';
                                                                // }
                                                                
                                                                // $sql = "INSERT INTO alum_prof (id_Prof, id_Alum) VALUES('$var','')";
                                                                // $sentencia=mysqli_stmt_init($conexion);
                                                                // mysqli_stmt_prepare($sentencia, $sql);
                                                                // mysqli_stmt_execute($sentencia);
                                                                // $resultado=mysqli_stmt_get_result($sentencia);
                                                                // $busqueda2 = mysqli_fetch_assoc($resultado);
                                                            }
                                                            
                                                            // echo '<table>';
                                                            
                                                            header("Location: ../enviarProfesor.php?var=$var");
                                                            echo $var;
                                                        }
                                                        
                                                        ?>
                                                        <!-- 
                                                        19420230
                                                        19420233
                                                        19420719
                                                        19420236
                                                        19420239
                                                        19420242
                                                        19420245
                                                        19420251
                                                        19420254
                                                        19420257
                                                        19420263
                                                        19420266
                                                        19420269
                                                        19420272
                                                        19420275
                                                        19420278
                                                        19420281
                                                        19420284
                                                        19420706
                                                        19420287
                                                        19420290
                                                        19420293
                                                        19420296
                                                        19420299
                                                        19420302
                                                        19420308
                                                        19420311
                                                        19420314
                                                        19420317
                                                        19420320
                                                        19420323
                                                        19420326
                                                        19420329
                                                        19420335 -->
                                                        