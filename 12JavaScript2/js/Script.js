

function mockCoches() {
    var marca1 = new Coches("BMW", ["Serie 1", "Serie 2", "Serie 3"]);
    var marca2 = new Coches("Audi", ["A1", "A3", "A4"]);
    var marca3 = new Coches("Volkswagen", ["Polo", "Golf", "Passat"]);

    var lista = [marca1, marca2, marca3];

    return lista;
}

window.onload = function () {

    var coches = mockCoches();

    console.log(coches);

}