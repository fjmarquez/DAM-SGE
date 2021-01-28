window.onload = function () {

    var btnRecorrer = document.getElementById("btnRecorrer");
    var btnAnadirFila = document.getElementById("btnAnadirFila");
    var btnEliminarFila = document.getElementById("btnEliminarFila");

    var tabla = document.getElementById("tabla");

    btnRecorrer.onclick = function (e) {
        recorrerTabla(tabla);
    }

    btnAnadirFila.onclick = function (e) {
        anadirFila(tabla);
    }

    btnEliminarFila.onclick = function (e) {
        eliminarFila(tabla);
    }

}

function anadirFila(tabla) {
    //alert(tabla);

    var nuevaFila = document.createElement("tr");

    var nFilas = tabla.rows.length;

    var nColumnas = tabla.rows[0].cells.length;

    for (var i = 1; i <= nColumnas; i++) {
        
        var nuevaCelda = document.createElement("td");

        var txtCelda = "Celda" + (nFilas+1).toString() + i.toString();

        nuevaCelda.innerHTML = txtCelda;

        nuevaFila.appendChild(nuevaCelda);
    }

    tabla.appendChild(nuevaFila);

}

function recorrerTabla(tabla) {
    for (var i = 0, row; row = tabla.rows[i]; i++){
        for (var j = 0, col; col = row.cells[j]; j++) {
            alert(col.innerHTML);
        } 
    }
}

function eliminarFila(tabla) {
    //alert(tabla);
    var nFilas = tabla.rows.length;

    var ultimaFila = nFilas - 1;

    tabla.deleteRow(ultimaFila);
     
}