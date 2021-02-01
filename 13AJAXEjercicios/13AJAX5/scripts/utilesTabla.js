/**
 * Esta funcion recibira una lista de personas y rellenara la tabla dinamicamente
 * 
 * @param {*} listaPersonas 
 */
function rellenarTabla(listaPersonas){

    //Identificamos los componentes de la tabla

    //var tabla = document.getElementById("tPersonas");

    var tHead = document.getElementById("tHeadPersonas");

    var tBody = document.getElementById("tBodyPersonas");

    //Obtenemos los nombre de las propiedades de la clase persona y creamos el head de la tabla dinamicamente
    var nombrePropiedades = Object.keys(listaPersonas[0]);

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

    
    for(var i = 0; i < listaPersonas.length; i++){

        var nuevaFila = document.createElement("tr");

        // Obtenemos los nombre de las propiedades de la clase persona y creamos las celdas correspondiente para cada fila del body
        for( x in listaPersonas[i]){ 

            var nuevaCelda = document.createElement("td");
            nuevaCelda.innerHTML = listaPersonas[i][x];
            nuevaFila.appendChild(nuevaCelda);//Añada cada celda a la fila

        }

        //Creamos los botones que permitira editar personas de la tabla
        var btnEditar = document.createElement("button");
        btnEditar.id = "btnEditar";
        btnEditar.className = "btn btn-secondary";
        btnEditar.innerHTML = "<i class='fas fa-user-edit'></i>";
        
        //nuevaFila.appendChild(nuevaCelda);

        btnEditar.onclick = function(e){

            fila = $(this).closest("tr");	
                    
            var persona = obtenerPersonaFila(fila);

            console.log(persona);

            document.getElementById("modalNombreEditar").value = persona['nombre'];

            document.getElementById("modalApellidosEditar").value = persona['apellidos'];
            
            document.getElementById("modalFNacimientoEditar").value = persona['fechaNacimiento'];

            document.getElementById("modalDireccionEditar").value = persona['direccion'];

            var modalTelefonoEditar = document.getElementById("modalTelefonoEditar").value = persona['telefono'];

            $("#modalEditar").modal("show");

            //MANDAR POST A LA API CON LOS NUEVOS DATOS DE LA PERSONA Y MODIFICAR LA FILA CORRESPONDIENTE

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

        btnEliminar.onclick = function(e){

            fila = $(this).closest("tr");	        
            
            var persona = obtenerPersonaFila(fila);

            console.log(persona);

            var bodyModalEliminar = document.getElementById("modal-body-eliminar");
            bodyModalEliminar.innerHTML = "¿Desea eliminar a " + persona['nombre'] + "?";
            

            $('#modalEliminar').modal('show');

            //MANDAR DELETE A LA API Y MOSTRAR MODAL (ELIMINADO CORRECTAMENTE) Y QUITAR FILA DE LA TABLA SI TODO SALE BIEN

        };


        var btnNuevo = document.getElementById("btnNuevo");
        btnNuevo.onclick = function(e){
            $('#modalNuevo').modal('show');
        }

    tBody.appendChild(nuevaFila); //Añade el body a la tabla

    }

}

/**
 * Obtiene todos los datos de la fila indicada
 * @param {*} fila 
 */
function obtenerPersonaFila(fila){

    //capturo los datos de la fila especificada de la tabla
    idFila = parseInt(fila.find('td:eq(0)').text());	            
    nombreFila = fila.find('td:eq(1)').text();
    apellidosFila = fila.find('td:eq(2)').text();
    fNacimientoFila = fila.find('td:eq(3)').text();
    direccionFila = fila.find('td:eq(4)').text();
    telfonoFila = fila.find('td:eq(5)').text();
    departamentoFila = fila.find('td:eq(6)').text();

    //creo un objeto persona con los datos de la fila
    var personaFila = new persona(idFila, nombreFila, apellidosFila, fNacimientoFila, direccionFila, telfonoFila, departamentoFila);

    return personaFila;    
}