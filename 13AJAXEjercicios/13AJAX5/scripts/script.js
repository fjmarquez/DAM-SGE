var listaPersonasAPI;
var listaDepartamentosAPI;

window.onload =  function(){

    obtenerDepartamentos().then((listaDepartamentosPromise)=>{
        listaDepartamentosAPI = listaDepartamentosPromise;
        obtenerPersonas().then((listaPersonasPromise) =>{
            listaPersonasAPI = listaPersonasPromise;
            var loader = document.getElementById("loader");
            loader.style.display = "none";
            rellenarTabla(listaPersonasAPI);
            botonesModales();
            buscadorNombre();
        });
        //console.log(listaDepartamentosPromise);
    });
    


    /*obtenerPersonas().then((listaPersonas) =>{
        $('#table').DataTable({
            "data": listaPersonas,
            "columns": [
              { "data": "id" },
              { "data": "nombre" },
              { "data": "apellidos" },
              { "data": "fechaNacimiento" },
              { "data": "direccion" },
              { "data": "telefono" },
              { "data": "Departamento" },
            ],
            "bAutoWidth": true
        });
    });*/

    

}

