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
            error: function(jqXHR, error){
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

    return new Promise((resolve, reject) => {

        $.ajax({
            url: "https://fjmarquezcrudnet.azurewebsites.net/api/personas/"+id, 
            method: "DELETE",
            success: function(response){
                resolve(response);
            },
            error: function(jqXHR, error){
                reject("Error en la peticion");
            }
        });

    });

}

/**
 * Con esta funcion editaremos los registros correspondientes a una persona en la BD mediante la API, recibiremos un objeto persona con 
 * los nuevos
 * @param {*} persona 
 */
function editarPersona(persona){

    
    return new Promise((resolve, reject) => {
        var personaJSON = JSON.stringify(persona);
        console.log(personaJSON); 
        $.ajax({
            url: "https://fjmarquezcrudnet.azurewebsites.net/api/personas", 
            method: "PUT",
            data: personaJSON,
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function(){
                resolve("OK");
            },
            error: function(jqXHR, error){
                reject("Fallo en la peticion");
            }
        });

    }).catch(e => {
        console.log(e);
    });

}

/**
 * Con esta funcion creamos los registros correspondientes a una nueva persona en la BD mediante la API, recibiremos un objeto persona con 
 * los nuevos
 * @param {*} persona 
 */
function nuevaPersona(persona){

    var personaJSON = JSON.stringify(persona);
    console.log(personaJSON); 
    return new Promise((resolve, reject) => {
        
        $.ajax({
            url: "https://fjmarquezcrudnet.azurewebsites.net/api/personas", 
            method: "POST",
            data: personaJSON,
            dataType: "json",
            contentType: "application/json",
            success: function(response){
                resolve(response);
            },
            error: function(jqXHR, error){
                reject("Error en la peticion");
            }
        });

    }).catch(e => {
        console.log(e);
    });

}

/**
 * Con esta funcion obtenemos un JSON con todos los depatamentos pero finalmente devolveremos un array de departamentos
 */
function obtenerDepartamentos(){
    return new Promise((resolve, reject) => {

        $.ajax({
            url: "https://fjmarquezcrudnet.azurewebsites.net/api/departamentos", 
            method: "GET",
            success: function(response){
                //console.log(response);
                var listaDepartamentos = jsonADepartamento(response);
                resolve(listaDepartamentos);
            },
            error: function(jqXHR, error){
                reject("Error en la peticion");
            }
        });

    });
}

/**
 * Esta funcion parseara el JSON obtenido a un array de personas
 * 
 * @param {*} listaJSON 
 */
function jsonAPersona(listaJSON){

    listaPersonas = [];

    for(var i = 0; i < listaJSON.length; i++){

        //Objeto departamento correspondiente a cada persona
        var departamentoP = listaDepartamentosAPI.find(departamento => departamento.id === listaJSON[i]["IdDepartamento"]);
        //console.log(departamentoP);

        var p = new persona(  listaJSON[i]["Id"],
                              listaJSON[i]["Nombre"], 
                              listaJSON[i]["Apellidos"],
                              listaJSON[i]["FechaNacimiento"],
                              listaJSON[i]["Direccion"],
                              listaJSON[i]["Telefono"],
                              departamentoP);
        
        listaPersonas.push(p);

    }

    //console.log(listaPersonas);
    return listaPersonas;
}

/**
 * Esta funcion parseara el JSON obtenido a un array de departamentos
 * 
 * @param {*} listaJSON 
 */
function jsonADepartamento(listaJSON){

    listaDepartamentos = [];

    for(var i = 0; i < listaJSON.length; i++){
        var d = new departamento(  listaJSON[i]["Id"],
                              listaJSON[i]["Departamento"]);
        
        listaDepartamentos.push(d);

    }

    //console.log(listaDepartamentos);
    return listaDepartamentos;
}

