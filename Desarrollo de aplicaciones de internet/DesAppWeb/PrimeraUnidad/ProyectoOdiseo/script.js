var state_table = document.getElementById("state-table");
var boton_alfabeto = document.getElementById("boton-alfabeto");
var boton_tabla = document.getElementById("boton-tabla");
var boton_cad = document.getElementById("boton-cad");
var aux = false;
var aux2 = false;


boton_alfabeto.onclick = function() {
    var text_alfabeto = document.getElementById("text-alfabeto").value;
    var text_estados = document.getElementById("text-estados").value;
    if (text_alfabeto == "") {
        alert("El alfabeto no puede estar vacio");
    } else if (text_estados == "") {
        alert("La cantidad de estados no puede estar vacia");
    } else {
        Llenar_State_Table(text_alfabeto, text_estados);
    }
}

function validar_solo_numeros(e) {

    var key = e.keyCode || e.which
    var teclado = String.fromCharCode(key);
    var numeros = "0123456789";
    var especiales = "8-37-38-46";
    var teclado_especial = false;
    for (var i in especiales) {
        if (key == especiales[i]) {
            teclado_especial = true;
        }
    }
    if (numeros.indexOf(teclado) == -1 && !teclado_especial) {
        return false;
    }
}

function validar_no_espacios(e) {
    var key = e.keyCode || e.which
    if (key == "32") {
        return false;
    }
    return true;
}

function cadena_nueva(cadena) {
    var cad = cadena.charAt(0);
    for (var i = 0; i < cadena.length; i++) {
        if (cad.indexOf(cadena.charAt(i)) == -1) {
            cad = cad + cadena.charAt(i);
        }
    }
    return cad;
}

function generar_select(estados, cadena) {
    var long_array = parseInt(estados) * cadena.length;
    // console.log(long_array);
    var selecs = new Array(long_array);
    for (let i = 0; i < selecs.length; i++) {
        var sel = document.createElement("SELECT");
        var nombre = "sel" + i;
        console.log("nombre: " + nombre);
        sel.setAttribute("id", nombre);
        selecs[i] = (sel);
        // document.getElementById("helper").appendChild(sel);
        // console.log(document.getElementById(nombre));
        for (let j = 0; j < parseInt(estados); j++) {
            var letra = cadena.charAt(j);
            var z = document.createElement("option");
            var nom = "Q" + j;
            console.log("nom: " + nom);
            z.setAttribute("value", nom);
            var t = document.createTextNode(nom);
            z.appendChild(t);
            selecs[i].appendChild(z);
        }
        var z = document.createElement("option");
        var nom = "E";
        z.setAttribute("value", nom);
        var t = document.createTextNode(nom);
        z.appendChild(t);
        selecs[i].appendChild(z);

        // selecs[i] = sel;
    }
    return selecs;
}

function generar_check(estados) {
    var long_array = parseInt(estados);
    var selecs = new Array(long_array);
    for (let j = 0; j < long_array; j++) {
        var chk_box = document.createElement("input");
        chk_box.type = "checkbox";
        chk_box.id = "AQ" + j;
        selecs[j] = chk_box;
        // document.getElementById("helper").appendChild(chk_box);
    }
    // console.log(selecs);
    return selecs;
}

function generar_filas(cadena, estados, alfabeto) {
    var selecs = generar_select(estados, alfabeto);
    var acepts = generar_check(estados);
    final_selecs = selecs;
    final_acepts = acepts;
    console.log(selecs);
    console.log(acepts);
    for (let j = 0, cont = 0; j < parseInt(estados); j++) {
        cadena = cadena + "<tr> <td>Q" + j + "</td>";
        for (let i = 0; i < alfabeto.length; i++) {
            cadena = cadena + " <td>" + selecs[cont].outerHTML + "</td>"
            cont++;
        }
        cadena = cadena + " <td>" + acepts[j].outerHTML + "</td>"
        cadena = cadena + "</tr>"
    }
    return cadena;
}

function generar_tabla(text_alfabeto, text_estados) {
    var cadena_genera_tabla = "<table><tr><td>Tabla</td>";
    for (var i = 0; i < text_alfabeto.length; i++) {
        cadena_genera_tabla = cadena_genera_tabla + "<td>" + text_alfabeto.charAt(i) + "</td>"
    }
    cadena_genera_tabla = cadena_genera_tabla + "<td>Aceptacion</td></tr>"
    cadena_genera_tabla = generar_filas(cadena_genera_tabla, text_estados, text_alfabeto);
    cadena_genera_tabla = cadena_genera_tabla + "</table>";
    return cadena_genera_tabla;
}


function Llenar_State_Table(text_alfabeto, text_estados) {
    var cad = cadena_nueva(text_alfabeto);
    var filas = generar_tabla(cad, text_estados);
    final_alfabeto = cad;
    final_estados = parseInt(text_estados);
    // console.log(filas);
    state_table.innerHTML = filas;
    aux = true;
}

boton_tabla.onclick = function() {
    if (aux) {
        var cad_val = document.getElementById("cad-val");
        cad_val.style.display = "flex";
        aux2 = true;
    }
}

var final_alfabeto = "";
var final_estados = 0;
var final_selecs = [];
var final_acepts = [];
var car_act = "";
var val_car = 0;
var salto = 0;

function validacion_super_mamalona_estoy_mamadisimo_hdp() {
    var cad_val = document.getElementById("cad-vali").value;
    for (let a = 0; a < final_alfabeto.length; a++) {
        for (let an = 0; an < cad_val.length; an++) {
            console.log("cad_val: " + cad_val.charAt(an));
            console.log("final_alfabeto: " + final_alfabeto.charAt(a));
            if ((final_alfabeto.indexOf(cad_val.charAt(an))) != -1) {
                //Todo Bien krnal
            } else {
                alert("la cadena contiene caracteres que no se encuentran en el alfabeto");
                return;
            }
        }
    }

    var cad_val = document.getElementById("cad-vali").value;

    for (var i = 0; i < cad_val.length; i++) {
        car_act = cad_val.charAt(i);

        for (var j = 0; j < final_alfabeto.length; j++) {
            if (car_act == final_alfabeto.charAt(j)) {
                val_car = j;
            }
        }

        var andrea = (salto * (final_selecs.length / final_estados));
        val_car = val_car + andrea;

        sel_actual = document.getElementById("sel" + val_car);

        var value = sel_actual[sel_actual.selectedIndex].value;

        for (var j = 0; j < final_estados; j++) {
            console.log(value);
            console.log("Q" + j)
            if (value == "Q" + j) {
                salto = j;
                console.log("Salto: " + salto);
                break;
            } else if (value == "E") {
                salto = j;
                alert("Cadena Invalida");
                limpiar_puerquero();
                return;
            }
        }
    }
    console.log("Llego al final de la cadena");
    var acep = document.getElementById("AQ" + salto);
    if (acep.checked) {
        alert("Cadena Valida");
        limpiar_puerquero();
        return;
    } else {
        alert("Cadena Invalida");
        limpiar_puerquero();
        return;
    }
}

function limpiar_puerquero() {
    car_act = "";
    val_car = 0;
    salto = 0;
}
boton_cad.onclick = function() {
    if (aux2) {
        validacion_super_mamalona_estoy_mamadisimo_hdp();
    }
}