
//Ejercicios 1 y 2

class Persona {
    constructor(nombre, apellidos) {
        this.nombre = nombre;
        this.apellidos = apellidos;
    }
}

function saludar() {
    var nombre = document.getElementById("txtNombre").value;
    var apellidos = document.getElementById("txtApellidos").value;
    var p = new Persona(nombre, apellidos);

    alert("Hola " + p.nombre + " " + p.apellidos);
}

window.onload = function () {

    var botonSaludar = document.getElementById("btnSaludar");

    botonSaludar.onclick = function (e) {
        saludar();
    }

}