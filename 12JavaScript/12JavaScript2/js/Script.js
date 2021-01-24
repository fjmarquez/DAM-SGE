

function mockCoches() {
    var marca1 = new Coches("BMW", ["Serie 1", "Serie 2", "Serie 3"]);
    var marca2 = new Coches("Audi", ["A1", "A3", "A4"]);
    var marca3 = new Coches("Volkswagen", ["Polo", "Golf", "Passat"]);

    var lista = [marca1, marca2, marca3];

    return lista;
}

window.onload = function () {

    var coches = mockCoches();

    var selectMarca = document.getElementById("marcas");
    var selectModelo = document.getElementById("modelos");

    for (var i = 0; i < coches.length; i++) {

        var selectOption = document.createElement("option");
        selectOption.text = coches[i].marca;
        selectMarca.add(selectOption);
        
    }

    selectMarca.onchange = function () {

        //alert("Cambio");

        var marcaSeleccionada = document.getElementById("marcas").value;

        selectModelo.innerHTML = "";

        for (var i = 0; i < coches.length; i++) {

            if (coches[i].marca == marcaSeleccionada) {

                for (var x = 0; x < coches.length; x++) {

                    var selectOption = document.createElement("option");
                    selectOption.text = coches[i].modelos[x];
                    selectModelo.add(selectOption);

                }
                    
            }

        }

    };

    



}