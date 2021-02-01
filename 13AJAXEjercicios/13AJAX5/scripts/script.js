window.onload =  function(){

    obtenerPersonas().then((listaPersonas) =>{

        
        
        
        var loader = document.getElementById("loader");
        loader.style.display = "none";
        rellenarTabla(listaPersonas);
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

