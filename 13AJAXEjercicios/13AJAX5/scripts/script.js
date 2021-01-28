window.onload = function(){

    obtenerPersonas();


}

/**
 * Con esta funcion obtenemos un JSON con todas las personas
 */
function obtenerPersonas(){

    var llamadaAjax = new XMLHttpRequest();
    llamadaAjax.open("GET", "https://fjmarquezcrudnet.azurewebsites.net/api/personas");

    llamadaAjax.onreadystatechange = function () {

        if (llamadaAjax.readyState < 4) {
            
        }
        else {

            if (llamadaAjax.readyState == 4 && llamadaAjax.status == 200) {

                listaJSON = JSON.parse(llamadaAjax.responseText);

                var listaPersonas = jsonAPersona(listaJSON);

                rellenarTabla(listaPersonas);
                
            }

        }

    };

    llamadaAjax.send();

}


/**
 * Esta funcion parseara el JSON obtenido a un array de personas
 * @param {*} listaJSON 
 */
function jsonAPersona(listaJSON){
    //alert(listaJSON);

    listaPersonas = [];

    for(var i = 0; i < listaJSON.length; i++){
        var p = new persona(  listaJSON[i]["Id"],
                              listaJSON[i]["Nombre"], 
                              listaJSON[i]["Apellidos"],
                              listaJSON[i]["FechaNacimiento"],
                              listaJSON[i]["Direccion"],
                              listaJSON[i]["Telefono"],
                              listaJSON[i]["IdDepartamento"]);
        
        listaPersonas.push(p);

    }

    //console.log(listaPersonas);
    return listaPersonas;
}


function rellenarTabla(listaPersonas){

    var tabla = document.getElementById("tablaPersonas");
    
    for(var i = 0; i < listaPersonas.length; i++){
        var nuevaFila = document.createElement("tr");

        //id
        var celdaId = document.createElement("td");
        celdaId.innerHTML = listaPersonas[i].id;
        nuevaFila.appendChild(celdaId);

        //nombre
        var celdaNombre = document.createElement("td");
        celdaNombre.innerHTML = listaPersonas[i].nombre;
        nuevaFila.appendChild(celdaNombre);

        //apellidos
        var celdaApellidos = document.createElement("td");
        celdaApellidos.innerHTML = listaPersonas[i].apellidos;
        nuevaFila.appendChild(celdaApellidos);

        //fecha nacimiento
        var celdaFNacimiento = document.createElement("td");
        celdaFNacimiento.innerHTML = listaPersonas[i].fNacimiento;
        nuevaFila.appendChild(celdaFNacimiento);

        //direccion
        var celdaDireccion = document.createElement("td");
        celdaDireccion.innerHTML = listaPersonas[i].direccion;
        nuevaFila.appendChild(celdaDireccion);

        //telefono
        var celdaTlf = document.createElement("td");
        celdaTlf.innerHTML = listaPersonas[i].tlf;
        nuevaFila.appendChild(celdaTlf);

        //departamento
        var celdaDpto = document.createElement("td");
        celdaDpto.innerHTML = listaPersonas[i].dpto;
        nuevaFila.appendChild(celdaDpto);

        //opciones
        var celdaOpciones = document.createElement("td");

        tabla.appendChild(nuevaFila);

    }

}