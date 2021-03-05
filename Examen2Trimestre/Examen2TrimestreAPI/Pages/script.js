//FRAN MARQUEZ

var listaMisionesAPI;
var tabla;
var boton;
var cambios;
var divRespuesta;

window.onload = function () {

    tabla = document.getElementById("tabla");
    divRespuesta = document.getElementById("respuesta");
    boton = document.getElementById("guardarCambios");
    boton.onclick = function (e) {
        cambios = 0;
        obtenerMisionesTabla();
    };

    getListaMisiones();

}


function getListaMisiones() {

    var llamadaAjax = new XMLHttpRequest();

    llamadaAjax.open("GET", "http://localhost:50605/api/misiones");

    llamadaAjax.onreadystatechange = function () {

        if (llamadaAjax.readyState < 4) {

        }
        else {

            if (llamadaAjax.readyState == 4 && llamadaAjax.status == 200) {

                var response = JSON.parse(llamadaAjax.responseText);

                listaMisionesAPI = jsonAMision(response);

                console.log(listaMisionesAPI);

                rellenarTabla();

            }

        }

    };

    llamadaAjax.send();

}

function updateMision(mision){

    var llamadaAjax = new XMLHttpRequest();

    llamadaAjax.open("PUT", "http://localhost:50605/api/misiones");
    llamadaAjax.setRequestHeader('Content-type', 'application/json; charset=utf-8');
    var json = JSON.stringify(mision);

    llamadaAjax.onreadystatechange = function () {

        if (llamadaAjax.readyState < 4) {

        }
        else {

            if (llamadaAjax.readyState == 4 && llamadaAjax.status == 200) {

                
                
            }

        }

    };

    llamadaAjax.send(json);

}

function rellenarTabla() {

    for (var i = 0; i < listaMisionesAPI.length; i++) {

        var nuevaFila = document.createElement("tr");

        for (x in listaMisionesAPI[i]) {

            var nuevaCelda = document.createElement("td");

            if (x == "Creditos") {
                nuevaCelda.id = "creditos";
                var inputText = document.createElement("input");
                inputText.value = (listaMisionesAPI[i][x]);
                nuevaCelda.appendChild(inputText);
            } else {
                nuevaCelda.innerHTML = listaMisionesAPI[i][x];
            }

            
            
            nuevaFila.appendChild(nuevaCelda);//Añada cada celda a la fila

        }

        tabla.appendChild(nuevaFila); //Añade el body a la tabla
    }
}

function obtenerMisionesTabla() {

    var i = -1;

    (tabla.querySelectorAll('tr')).forEach((fila) => {

        fila.querySelectorAll('td').forEach((celda) => {
            if (celda.id == "creditos" && i >=0) {
                celda.querySelectorAll('input').forEach((inputCelda) => {
                    var creditosfila = inputCelda.value;
                    if (creditosfila != listaMisionesAPI[i]["Creditos"]) {
                        listaMisionesAPI[i]["Creditos"] = creditosfila;
                        cambios++;
                        updateMision(listaMisionesAPI[i]);
                    }
                        
                });
            }
        });
        i++;
    });

    divRespuesta.innerHTML = "Cambios realizados (" + cambios + ")";

}

function jsonAMision(listaJSON) {

    listaMisiones = [];

    for (var i = 0; i < listaJSON.length; i++) {
        var d = new Mision(
            listaJSON[i]["Id"],
            listaJSON[i]["Nombre"],
            listaJSON[i]["Descripcion"],
            listaJSON[i]["Creditos"],
            listaJSON[i]["Completada"]
        );

        listaMisiones.push(d);

    }

    //console.log(listaMisiones);
    return listaMisiones;
}