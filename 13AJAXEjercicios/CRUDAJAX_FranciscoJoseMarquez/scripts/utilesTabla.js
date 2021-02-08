/**
 * Esta funcion recibira una lista de personas y rellenara la tabla dinamicamente
 * 
 * @param {*} listaPersonas 
 */
function rellenarTabla(listaPersonas) {

    //Identificamos los componentes de la tabla y eliminamos el contenido que pueda contener

    var tHead = document.getElementById("tHeadPersonas");
    tHead.innerHTML = "";
    var tBody = document.getElementById("tBodyPersonas");
    tBody.innerHTML = "";

    //Obtenemos los nombre de las propiedades de la clase persona y creamos el head de la tabla dinamicamente
    var nombrePropiedades = Object.keys(listaPersonas[0]);

    var filaHead = document.createElement("tr");

    for (var i = 0; i < nombrePropiedades.length; i++) {

        var celdaHead = document.createElement("th");
        celdaHead.innerHTML = nombrePropiedades[i].charAt(0).toUpperCase() + nombrePropiedades[i].slice(1).toLowerCase(); //Capitalizado
        filaHead.appendChild(celdaHead);//Añada cada celda a la fila

    }

    //Añadimos la columna opciones manualmente
    celdaHead = document.createElement("th");
    celdaHead.innerHTML = "Opciones";
    filaHead.appendChild(celdaHead);

    tHead.appendChild(filaHead); //Añade la cabecera a la tabla

    for (var i = 0; i < listaPersonas.length; i++) {

        var nuevaFila = document.createElement("tr");

        // Obtenemos los nombre de las propiedades de la clase persona y creamos las celdas correspondiente para cada fila del body
        for (x in listaPersonas[i]) {

            var nuevaCelda = document.createElement("td");

            if (x == "FechaNacimiento") {
                nuevaCelda.innerHTML = listaPersonas[i][x].split('T')[0];
            }
            else if (x == "IdDepartamento") {
                nuevaCelda.innerHTML = listaPersonas[i][x].nDepartamento;
            } else {
                nuevaCelda.innerHTML = listaPersonas[i][x];
            }

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
function crearBotones(nuevaFila) {

    //Creamos los botones que permitira editar personas de la tabla
    var btnEditar = document.createElement("button");
    btnEditar.id = "btnEditar";
    btnEditar.className = "btn btn-secondary";
    btnEditar.innerHTML = "<i class='fas fa-user-edit'></i>";

    btnEditar.onclick = function (e) {

        //Obtengo la fila de la tabla donde he pulsado el boton, y obtengo todos los valores de las celdas de esa fila
        fila = $(this).closest("tr");
        var valoresFila = obtenerPersonaFila(fila);

        //Obtengo la persona correspondiente al contenido de la fila en la hemos pulsado un boton
        var personaFila = listaPersonasAPI.find(persona => persona.Id == valoresFila.Id);
        console.log(personaFila);

        //Relleno el formulario correspondiente al modal eliminar con los datos correspondientes
        document.getElementById("modalIDEditar").value = personaFila.Id;
        document.getElementById("modalNombreEditar").value = personaFila.Nombre;
        document.getElementById("modalApellidosEditar").value = personaFila.Apellidos;
        $('#modalFNacimientoEditar').datepicker('setDate', new Date(personaFila.FechaNacimiento));
        document.getElementById("modalDireccionEditar").value = personaFila.Direccion;
        document.getElementById("modalTelefonoEditar").value = personaFila.Telefono;
        rellenarSelectDepartamentos("editar");
        document.getElementById("modalDepartamentoEditar").value = personaFila.IdDepartamento.id;

        //Muestro el modal
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

        //Obtengo la fila de la tabla donde he pulsado el boton, y obtengo todos los valores de las celdas de esa fila
        fila = $(this).closest("tr");
        var valoresFila = obtenerPersonaFila(fila);

        //Obtengo la persona correspondiente al contenido de la fila en la hemos pulsado un boton
        var personaFila = listaPersonasAPI.find(persona => persona.Id == valoresFila.Id);

        //Establezco un mensaje de confirmacion sobre la persona que se va a eliminar
        var bodyModalEliminar = document.getElementById("modal-body-confirmacion-eliminar");
        bodyModalEliminar.innerHTML = "¿Desea eliminar a " + personaFila['Nombre'] + " " + personaFila['Apellidos'] + "?";

        //Asigno el id como valor a un input hidden
        document.getElementById("modalIDEliminar").value = personaFila['Id'];

        //Muestro el modal
        $('#modalEliminar').modal('show');

    };

    //Identificamos btnNuevo y le proporcionamos una funcion
    var btnNuevo = document.getElementById("btnNuevo");
    btnNuevo.onclick = function (e) {

        //Establezco una fecha por defecto en el datepicker
        $('#modalFNacimientoNuevo').datepicker('setDate', new Date());

        //Relleno el select de departamentos
        rellenarSelectDepartamentos("nuevo");

        //Muestro el modal
        $('#modalNuevo').modal('show');
    }

}

/**
 * Esta funcion rellenara los diferentes selects destinados a elegir el departamento de la persona
 * con sus elementos option correspondientes
 * @param {*} modal 
 */
function rellenarSelectDepartamentos(modal) {
    var selectDepartamentos;

    //Dependiendo de el parametro recibido selctDepartamentos hara referencia a modalEditar o a modalNuevo
    if (modal == "editar") {
        selectDepartamentos = document.getElementById("modalDepartamentoEditar");
        selectDepartamentos.innerHTML = "";
    } else {
        selectDepartamentos = document.getElementById("modalDepartamentoNuevo");
        selectDepartamentos.innerHTML = "";
    }

    //Insertamos los options con sus correspondientes text y values
    for (i = 0; i < listaDepartamentosAPI.length; i++) {
        var optionDepartamento = document.createElement("option");
        optionDepartamento.text = listaDepartamentosAPI[i].nDepartamento;
        optionDepartamento.value = listaDepartamentosAPI[i].id;
        selectDepartamentos.appendChild(optionDepartamento);
    }
}

/**
 * Definimos la funcionalidad de los botones en los modales que usamos para editar y crear una nueva persona
 */
function botonesModales() {
    //Editar
    var btnEditarModal = document.getElementById("btn-modal-editar");
    var formEditar = document.getElementById("formEditar");
    btnEditarModal.onclick = function (e) {
        var personaEditar = new persona();
        //Recorremos los input del formulario que tenemos en el modalEditar y obtenemos sus valores
        (formEditar.querySelectorAll('input')).forEach((elemento) => {

            for (x in personaEditar) {
                if (personaEditar[x] == undefined) {
                    personaEditar[x] = elemento.value;
                    break;
                }
            }
        });
        //Asginamos el id de departamento seleccionado, no se hace en el forEach anterio debido a que no se trata de un input
        personaEditar.IdDepartamento = document.getElementById("modalDepartamentoEditar").value;

        editarPersona(personaEditar).then((response) => {
            $('#modalEditar').modal('hide');
            obtenerPersonas().then((listaPersonasPromise) => {
                listaPersonasAPI = listaPersonasPromise;
                rellenarTabla(listaPersonasAPI);
                botonesModales();
            });
        });

    }

    //Nueva
    var btnNuevoModal = document.getElementById("btn-modal-nuevo");
    var formNuevo = document.getElementById("formNuevo");
    btnNuevoModal.onclick = function (e) {
        var personaNuevo = new persona();
        (formNuevo.querySelectorAll('input')).forEach((elemento) => {

            for (x in personaNuevo) {
                if (x != "Id") {
                    if (personaNuevo[x] == undefined) {
                        personaNuevo[x] = elemento.value;
                        break;
                    }
                }
            }
        });

        //Asignamos un id 0 a la nueva persona
        personaNuevo.Id = 0;
        //Asginamos el id de departamento seleccionado, no se hace en el forEach anterio debido a que no se trata de un input
        personaNuevo.IdDepartamento = document.getElementById("modalDepartamentoNuevo").value;

        nuevaPersona(personaNuevo).then((response) => {
            $('#modalNuevo').modal('hide');
            obtenerPersonas().then((listaPersonasPromise) => {
                listaPersonasAPI = listaPersonasPromise;
                rellenarTabla(listaPersonasAPI);
                botonesModales();
            });
        });

    }

    //Eliminar
    var btnEliminarModal = document.getElementById("btn-modal-eliminar");
    btnEliminarModal.onclick = function (e) {
        var idEliminar = document.getElementById("modalIDEliminar").value;

        eliminarPersona(idEliminar).then((response) => {
            $('#modalEliminar').modal('hide');
            obtenerPersonas().then((listaPersonasPromise) => {
                listaPersonasAPI = listaPersonasPromise;
                rellenarTabla(listaPersonasAPI);
                botonesModales();
            });
        });
    }

}

/**
 * Esta funcion se encargara de filtrar por cualquier propiedad de la clase persona, en funcion
 * de lo que el usuario introduzca en el input destinado a ello
 */
function buscadorNombre() {
    //Identificamos el input de busqueda
    var inputBusqueda = document.getElementById("inputBuscador");

    //Le añadimos un evento Change y filtramos el array principal de personas segun el parametro recibido
    inputBusqueda.addEventListener('keyup', (event) => {
        var busqueda = inputBusqueda.value.toLowerCase();
        
        var resultados = [];

        for (var i = 0; i < listaPersonasAPI.length; i++) {
            for (x in listaPersonasAPI[i]) {
                var propiedad = listaPersonasAPI[i][x].toString().toLowerCase();
                if (propiedad.includes(busqueda)) {
                    resultados.push(listaPersonasAPI[i]);
                    break;
                }
            }
        }
        //Rellenamos la tabla con los resultados obtenidos
        rellenarTabla(resultados);
    });
}

/**
 * Obtiene todos los datos de la fila indicada
 * @param {*} fila 
 */
function obtenerPersonaFila(fila) {

    var personaFila = new persona();
    for (var i = 0; i < Object.keys(new persona).length; i++) {
        for (x in personaFila) {
            if (personaFila[x] == undefined) {
                personaFila[x] = fila.find('td:eq(' + i + ')').text();
                break;
            }
        }
    }

    return personaFila;
}