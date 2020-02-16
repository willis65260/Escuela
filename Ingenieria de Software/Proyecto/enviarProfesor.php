
<div class="contenedor T" id="con">
        
        <?php require 'header.php';
        
        if(!isset($_GET['var'])){
                $m=$_GET['mens'];
            }else{
                $m=$_GET['var'];
            }
        ?>
        <div class="informacionp">
                <form action="cosasPHP/enviarArchivo.php" method="POST" enctype="multipart/form-data">
                        <label for="archivo">Subir archivo de usuarios y actualizar usuarios</label>
                        <input type="file" name="archivo">
                        <input type="hidden" name="var" value="<?= isset($m)?htmlspecialchars($m):'' ?>">
                        <input type="submit" value="Actualizar Usuarios" name="Actualizar" id="boton">

                        <label for="archivo">Subir Calificaciones</label>
                        <input type="file" name="archivoCalif">
                        <input type="submit" value="Subir Calificaciones" name="Calificaciones" id="boton">

                        <label for="Alumno">Eliminar Alumno</label>
                        <input type="text" name="Alumno" placeholder="Alumno a eliminar">
                        <input type="submit" value="Eliminar Alumno" name="Eliminar" id="boton">

                        <label for="archivo">Cambiar Contraseña</label>
                        <input type="text" name="Cambiar" placeholder="Ingrese Nueva Contraseña">
                        <input type="submit" value="Actualizar Contraseña" name="Contrase" id="boton">

                        <input type="button" value="Regresar" name="Regresar" id="boton">
                        
                </form>
                
        </div>
        
        
      
        <?php require 'footer.php' ?>
</div>
</body>
</html>


    