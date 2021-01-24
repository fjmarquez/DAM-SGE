window.onload = function () {

    var btn = document.getElementById("btnBorrarPersona");

    btn.onclick = function (e) {
        llamadaAjax();
    };

    //btn.addEventListener("click", llamadaAjax);

}



function llamadaAjax() {
    //alert("Hola Mundo");

    var llamadaAjax = new XMLHttpRequest();
    var idPersona = document.getElementById("idPersonaBorrar").value;
    console.log(idPersona);
    
    llamadaAjax.open("DELETE", "https://fjmarquezcrudnet.azurewebsites.net/api/personas/" + idPersona);

    llamadaAjax.onreadystatechange = function () {

        if (llamadaAjax.readyState < 4) {
            
        }
        else {

            if (llamadaAjax.readyState == 4 && llamadaAjax.status == 200) {

                //AQUI NO ENTRA, SOLO LLEGA AL READYSTATE 2

                console.log(llamadaAjax.responseText);

                document.getElementById("idPersonaBorrar").innerHTML = "";

                document.getElementById("respuesta").innerHTML = "Persona elimianda";

            }

        }

    };

    llamadaAjax.send();

}