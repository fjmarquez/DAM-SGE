/**
 * Con esta funcion obtenemos un JSON con todas las personas pero finalmente devolveremos un array de personas
 */
function obtenerPersonas(){

    return new Promise((resolve, reject) => {

        $.ajax({
            url: "https://fjmarquezcrudnet.azurewebsites.net/api/personas", 
            method: "GET",
            success: function(response){
                var listaPersonas = jsonAPersona(response);
                resolve(listaPersonas);
            },
            error: function(jqXHR, departamentoFila, error){
                reject("Error en la peticion");
            }
        });

    });

}

/**
 * Con esta funcion eliminaremos una persona de nuestra BD mediante la API, recibiremos el id de la persona a eliminar
 * @param {*} id 
 */
function eliminarPersona(id){

}

/**
 * Con esta funcion editaremos los registros correspondientes a una persona en la BD mediante la API, recibiremos un objeto persona con 
 * los nuevos
 * @param {*} persona 
 */
function editarPersona(persona){

}

/**
 * Esta funcion parseara el JSON obtenido a un array de personas
 * 
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

