var state_table = document.getElementById("state-table");
var boton_alfabeto = document.getElementById("boton-alfabeto");
var boton_tabla = document.getElementById("boton-tabla");
var boton_cad = document.getElementById("boton-cad");
var aux = false;
var aux2 = false;


// boton_alfabeto.onclick = function() {
//     var text_alfabeto = document.getElementById("text-alfabeto").value;
//     var text_estados = document.getElementById("text-estados").value;
//     if (text_alfabeto == "") {
//         alert("El alfabeto no puede estar vacio");
//     } else if (text_estados == "") {
//         alert("La cantidad de estados no puede estar vacia");
//     } else {
//         Llenar_State_Table(text_alfabeto, text_estados);
//     }
// }

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
        // console.log("nombre: " + nombre);
        sel.setAttribute("id", nombre);
        selecs[i] = (sel);
        //Le añado como estado inicial, un estado de error 
        var z = document.createElement("option");
        var nom = "E";
        z.setAttribute("value", nom);
        var t = document.createTextNode(nom);
        z.appendChild(t);
        selecs[i].appendChild(z);
        // document.getElementById("helper").appendChild(sel);
        // console.log(document.getElementById(nombre));
        for (let j = 0; j < parseInt(estados); j++) {
            var letra = cadena.charAt(j);
            var z = document.createElement("option");
            var nom = "Q" + j;
            // console.log("nom: " + nom);
            z.setAttribute("value", nom);
            var t = document.createTextNode(nom);
            z.appendChild(t);
            selecs[i].appendChild(z);
        }


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
    // console.log(selecs);
    // console.log(acepts);
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

// boton_tabla.onclick = function() {
//     if (aux) {
//         var cad_val = document.getElementById("cad-val");
//         cad_val.style.display = "flex";
//         aux2 = true;
//     }
// }

function Llenar_Alfabeto() {
    /*Llenar El alfabeto con el codigo ascci de 
    0-256 exceptuando la cadena Vacia*/
}

var final_alfabeto = "";
var final_estados = 18;
var final_selecs = [];
var final_acepts = [];
var car_act = "";
var val_car = 0;
var salto = 0;
var c_c = new Array(256);
var cc_texto = "";

function Acomodar_Checks() {
    document.getElementById("AQ" + 1).checked = 1;
    document.getElementById("AQ" + 3).checked = 1;
    document.getElementById("AQ" + 5).checked = 1;
    document.getElementById("AQ" + 7).checked = 1;
    document.getElementById("AQ" + 10).checked = 1;
    document.getElementById("AQ" + 11).checked = 1;
    document.getElementById("AQ" + 14).checked = 1;
    document.getElementById("AQ" + 17).checked = 1;
}

function Acomodar_Selecs() {

    for (let s = 0; s < final_estados; s++) {
        for (let vc = 0; vc < final_alfabeto.length; vc++) {
            var andrea = (s * (final_selecs.length / final_estados));
            var v2 = vc + andrea;
            if (s == 0) {
                if (v2 == 48 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 2;
                }
                if (v2 == 45 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 5;
                }
                if (v2 >= 49 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 6;
                }
                if (v2 == 95 + andrea || (v2 >= 65 + andrea && v2 <= 122 + andrea)) {
                    document.getElementById("sel" + v2).selectedIndex = 12;
                }
                if (v2 == 39 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 13;
                }
                if (v2 == 34 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 16;
                }
            }

            if (s == 1) {
                if (v2 == 46 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 3;
                }
            }

            if (s == 2) {
                if (v2 == 48 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 4;
                }
                if (v2 >= 49 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 6;
                }
            }

            if (s == 3) {
                if (v2 >= 48 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 6;
                }
            }

            if (s == 4) {
                if (v2 >= 49 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 8;
                }
            }

            if (s == 5) {
                if (v2 >= 48 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 6;
                }
                if (v2 == 46 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 7;
                }
                if (v2 == 101 + andrea || v2 == 69 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 9;
                }
            }

            if (s == 6) {
                if (v2 == 48 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 7;
                }
                if (v2 >= 49 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 8;
                }
            }

            if (s == 7) {
                if (v2 == 101 + andrea || v2 == 69 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 9;
                }
            }

            if (s == 8) {
                if (v2 == 45 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 10;
                }
                if (v2 >= 49 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 11;
                }
            }

            if (s == 9) {
                if (v2 >= 49 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 11;
                }
            }

            if (s == 10) {
                if (v2 >= 48 + andrea && v2 <= 57 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 11;
                }
            }

            if (s == 11) {
                if (v2 == 95 + andrea || (v2 >= 65 + andrea && v2 <= 122 + andrea) || (v2 >= 48 + andrea && v2 <= 57 + andrea)) {
                    document.getElementById("sel" + v2).selectedIndex = 12;
                }
            }

            if (s == 12) {
                if ((v2 >= 0 + andrea && v2 <= 38 + andrea) || (v2 >= 40 + andrea && v2 <= 256 + andrea)) {
                    document.getElementById("sel" + v2).selectedIndex = 14;
                }
                if (v2 == 39 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 15;
                }
            }

            if (s == 13) {
                if (v2 == 39 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 15;
                }
            }

            if (s == 15) {
                if ((v2 >= 0 + andrea && v2 <= 33 + andrea) || (v2 >= 35 + andrea && v2 <= 256 + andrea)) {
                    document.getElementById("sel" + v2).selectedIndex = 17;
                }
                if (v2 == 34 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 18;
                }
            }

            if (s == 16) {
                if ((v2 >= 0 + andrea && v2 <= 33 + andrea) || (v2 >= 35 + andrea && v2 <= 256 + andrea)) {
                    document.getElementById("sel" + v2).selectedIndex = 17;
                }
                if (v2 == 34 + andrea) {
                    document.getElementById("sel" + v2).selectedIndex = 18;
                }
            }

        }
    }
}

function Separar_por_espacios_en_blanco(ceneval) {
    var cads = new Array();
    var cad_aux = "";
    console.log(ceneval);
    // console.log(cad_val.charCodeAt(''));
    for (var i = 0; i < ceneval.length; i++) {
        // if (cad_val.charAt(i) != " ") {
        //     cad_aux = cad_aux + cad_val.charAt(i);
        // } else {
        //     cads.push(cad_aux);
        //     console.log(cad_aux);
        //     cad_aux = "";
        // }
        if (ceneval.charAt(i) == " ") {
            cads.push(cad_aux);
            console.log(cad_aux);
            cad_aux = "";
        } else {
            cad_aux = cad_aux + ceneval.charAt(i);
        }
    }
    cads.push(cad_aux);
    console.log(cad_aux);
    return cads;
}

function validacion_super_mamalona_estoy_mamadisimo_hdp() {
    var cad_val = document.getElementById("cad-vali").value;
    // for (let a = 0; a < final_alfabeto.length; a++) {
    //     for (let an = 0; an < cad_val.length; an++) {
    //         console.log("cad_val: " + cad_val.charAt(an));
    //         console.log("final_alfabeto: " + final_alfabeto.charAt(a));
    //         if ((final_alfabeto.indexOf(cad_val.charAt(an))) != -1) {
    //             //Todo Bien krnal
    //         } else {
    //             alert("la cadena contiene caracteres que no se encuentran en el alfabeto");
    //             return;
    //         }
    //     }
    // }

    // console.log("Hola");

    // var cadenas = Separar_por_espacios_en_blanco(cade);
    // console.log(cadenas + " longitud " + cadenas.length);
    // for (var k = 0; k < cadenas.length; k++) {
    //     var cad_val = "";

    //     console.log(cadenas[k]);

    //     cad_val = cadenas.indexOf(k);
    //     console.log(cad_val);


    for (var c_caracter = 0; c_caracter < c_c.length; c_caracter++) {
        c_c[c_caracter] = String.fromCharCode(c_caracter);
        cc_texto = cc_texto + "" + String.fromCharCode(c_caracter);
        // console.log(c_c[c_caracter]);
    }
    final_alfabeto = cc_texto;

    // console.log(final_alfabeto);
    Llenar_State_Table(final_alfabeto, final_estados);
    Acomodar_Selecs();
    Acomodar_Checks();

    // console.log(cc_texto);
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
        // console.log("val_car: " + val_car);
        // console.log("andrea: " + andrea);
        sel_actual = document.getElementById("sel" + val_car);
        // console.log("sel" + val_car);
        // console.log(sel_actual);
        // console.log(final_alfabeto);

        var value = sel_actual.value;

        for (var j = 0; j < final_estados; j++) {
            // console.log(value);
            // console.log("Q" + j)
            if (value == "Q" + j) {
                salto = j;
                // console.log("Salto: " + salto);
                break;
            } else if (value == "E") {
                salto = j;
                // console.log(salto);
                alert("Cadena Invalida 1 " + cad_val + " salto " + salto);
                limpiar_puerquero();
                return;
            }
        }
    }
    // console.log("Llego al final de la cadena");
    var acep = document.getElementById("AQ" + salto);
    var mensaje = "";
    if (acep.checked) {
        if (salto == 1 || salto == 5) {
            mensaje = "Entero";
            if (cad_val.indexOf('.')) {
                mensaje = "Flotante";
            }
        } else if (salto == 3 || salto == 7 || salto == 10) {
            mensaje = "Flotante";
        } else if (salto == 11) {
            mensaje = "Identificador";
        } else if (salto == 14) {
            mensaje = "Char";
        } else if (salto == 17) {
            mensaje = "Cadena";
        }
        alert("Cadena Valida es un/a " + mensaje + " " + cad_val);
        limpiar_puerquero();
        return;
    } else {
        alert("Cadena Invalida 2 " + cad_val + " " + salto);
        limpiar_puerquero();
        return;
    }

}
// }

function limpiar_puerquero() {
    car_act = "";
    val_car = 0;
    salto = 0;
}
boton_cad.onclick = function() {
    // if (aux2) {
    validacion_super_mamalona_estoy_mamadisimo_hdp();
    // }
}