

<?php require 'cosasPHP/conexion.php' ?>
<?php
                if(!isset($_GET['mens'])){
                    $m='Profesor';
                }else{
                    $m=$_GET['mens'];
                }
            ?>
<form action='cosasPHP/enviar.php' method="POST">
<h2> <?php echo 'Ingresar '.$m; ?> </h2>
            <input type="text" name="nombre" placeholder="usuario" required>
            <input type="password" name="contra" placeholder="contraseña" required>
            <!-- <select name="asunto" id="asun" aria-placeholder="Seleccione un asunto">
                <option value="0">seleccione un asunto</option>
                <option value="1">Trabajo</option>
                <option value="2">Contacto</option>
                <option value="3">Personal</option>
            </select> -->
            <!-- <textarea name="mensaje" placeholder="Escriba aqui su mensaje" id="" cols="30" rows="10" required></textarea> -->
            <input type="hidden" name="pagina" value="<?= isset($m)?htmlspecialchars($m):'' ?>">
            <input type="submit" name="enviar" value="enviar" id="boton">
        </form>

