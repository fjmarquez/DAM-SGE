/**
 * Esta funcion recibira una lista de personas y rellenara la tabla dinamicamente
 * 
 * @param {*} listaPersonas 
 */
function rellenarTabla(){

    //Identificamos los componentes de la tabla

    //var tabla = document.getElementById("tPersonas");

    var tHead = document.getElementById("tHeadPersonas");

    var tBody = document.getElementById("tBodyPersonas");

    //Obtenemos los nombre de las propiedades de la clase persona y creamos el head de la tabla dinamicamente
    var nombrePropiedades = Object.keys(listaPersonasAPI[0]);

    var filaHead = document.createElement("tr");

    for(var i = 0; i < nombrePropiedades.length; i++){
        
        var celdaHead = document.createElement("th");

        celdaHead.innerHTML = nombrePropiedades[i].charAt(0).toUpperCase() + nombrePropiedades[i].slice(1).toLowerCase(); //Capitalizado
        
        filaHead.appendChild(celdaHead);//Añada cada celda a la fila
        
    }

    //Añadimos la columna opciones manualmente
    celdaHead = document.createElement("th");
    celdaHead.innerHTML = "Opciones";
    filaHead.appendChild(celdaHead);

    tHead.appendChild(filaHead); //Añade la cabecera a la tabla

    for(var i = 0; i < listaPersonasAPI.length; i++){

        var nuevaFila = document.createElement("tr");

        // Obtenemos los nombre de las propiedades de la clase persona y creamos las celdas correspondiente para cada fila del body
        for( x in listaPersonasAPI[i]){ 

            if(x == "fechaNacimiento"){
                listaPersonasAPI[i][x] = listaPersonasAPI[i][x].split('T')[0];
            }

            var nuevaCelda = document.createElement("td");

            nuevaCelda.innerHTML = listaPersonasAPI[i][x];

            nuevaFila.appendChild(nuevaCelda);//Añada cada celda a la fila

        }

        crearBotones(nuevaFila);

    tBody.appendChild(nuevaFila); //Añade el body a la tabla

    }

}

/**
 * Esta funcion recibira la fila en la que estamos insertando actualmente y
 * generara los botones editar, eliminar y nuevo
 * @param {*} nuevaFila 
 */
function crearBotones(nuevaFila){

    //Creamos los botones que permitira editar personas de la tabla
    var btnEditar = document.createElement("button");
    btnEditar.id = "btnEditar";
    btnEditar.className = "btn btn-secondary";
    btnEditar.innerHTML = "<i class='fas fa-user-edit'></i>";

    //nuevaFila.appendChild(nuevaCelda);

    btnEditar.onclick = function (e) {

        fila = $(this).closest("tr");

        var persona = obtenerPersonaFila(fila);

        //console.log(persona);

        document.getElementById("modalIDEditar").value = persona['id'];

        document.getElementById("modalNombreEditar").value = persona['nombre'];

        document.getElementById("modalApellidosEditar").value = persona['apellidos'];

        //document.getElementById("modalFNacimientoEditar").value = persona['fechaNacimiento'];

        $('#modalFNacimientoEditar').datepicker('setDate', new Date(persona['fechaNacimiento']));


        document.getElementById("modalDireccionEditar").value = persona['direccion'];

        document.getElementById("modalTelefonoEditar").value = persona['telefono'];

        $("#modalEditar").modal("show");

    };

    //Creamos los botones que permitiran eliminar personas de la tabla
    var btnEliminar = document.createElement("button");
    btnEliminar.id = "btnEliminar";
    btnEliminar.className = "btn btn-danger";
    btnEliminar.innerHTML = "<i class='fas fa-trash'></i>";

    var nuevaCelda = document.createElement("td");
    nuevaCelda.appendChild(btnEditar);
    nuevaCelda.appendChild(btnEliminar);
    nuevaFila.appendChild(nuevaCelda);

    btnEliminar.onclick = function (e) {

        fila = $(this).closest("tr");
        var persona = obtenerPersonaFila(fila);

        var bodyModalEliminar = document.getElementById("modal-body-confirmacion-eliminar");
        bodyModalEliminar.innerHTML = "¿Desea eliminar a " + persona['nombre'] + "?";

        document.getElementById("modalIDEliminar").value = persona['id'];

        $('#modalEliminar').modal('show');

    };

    //Identificamos btnNuevo y le proporcionamos una funcion
    var btnNuevo = document.getElementById("btnNuevo");
        btnNuevo.onclick = function(e){

            $('#modalFNacimientoNuevo').datepicker('setDate', new Date());

            $('#modalNuevo').modal('show');
        }

}


function botonesModales(){
    //Editar
    var btnEditarModal = document.getElementById("btn-modal-editar");
    var formEditar = document.getElementById("formEditar");
    btnEditarModal.onclick = function(e){
        var personaEditar = new persona();
        (formEditar.querySelectorAll('input')).forEach((elemento) => {

            for(x in personaEditar){
                if(personaEditar[x] == undefined){
                    personaEditar[x] = elemento.value;
                    break;
                }
            }
          });

        console.log(personaEditar);

    }

    //Nueva
    var btnNuevoModal = document.getElementById("btn-modal-nuevo");
    var formNuevo = document.getElementById("formNuevo");
    btnNuevoModal.onclick = function(e){
        var personaNuevo = new persona();
        (formNuevo.querySelectorAll('input')).forEach((elemento) => {

            for(x in personaNuevo){
                if(personaNuevo[x] == undefined){
                    personaNuevo[x] = elemento.value;
                    break;
                }
            }
          });

        console.log(personaNuevo);

    }

    //Eliminar
    var btnEliminarModal = document.getElementById("btn-modal-eliminar");
    btnEliminarModal.onclick = function (e) {

    }

}

/**
 * Obtiene todos los datos de la fila indicada
 * @param {*} fila 
 */
function obtenerPersonaFila(fila){

    var personaFila = new persona();
    for(var i = 0; i < Object.keys(new persona).length; i++){
        for(x in personaFila){
            if(personaFila[x] == undefined){
                personaFila[x] = fila.find('td:eq(' + i + ')').text();
                break;
            }
        }
    }

    console.log(personaFila);
    
    return personaFila;    
}