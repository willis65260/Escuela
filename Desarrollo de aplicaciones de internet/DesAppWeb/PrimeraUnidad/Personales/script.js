var Pelota = document.getElementById("pelota");
var velocidad = 300;
var vel_inicial = 0;

set_pelota();


function set_pelota() {
    Pelota.style.background = "green";
    Pelota.style.height = "75px";
    Pelota.style.width = "75px";
    Pelota.style.borderRadius = "50%";
    rebotar();
}

function sleep(miliseconds) {
    const date = Date.now();
    let currentdate = null;
    do {
        currentdate = Date.now();
        console.log((currentdate - date) + "");
    } while ((currentdate - date) < miliseconds)
}

function rebotar() {
    // cambiar_tamaño_en_funcion_del_centro();
    // for (var i = 0; i < 10; i++) {

    Pelota.style.position = "absolute";
    Pelota.style.left = vel_inicial + velocidad + "px";
    vel_inicial = vel_inicial + velocidad;

    sleep(2000);
    Pelota.style.position = "absolute";
    Pelota.style.left = vel_inicial + velocidad + "px";
    // }

}