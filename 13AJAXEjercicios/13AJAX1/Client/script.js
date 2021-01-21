window.onload = function () {

    var btn = document.getElementById("btnHolaMundo");

    btn.onclick = function (e) {
        llamadaAjax();
    };

    //btn.addEventListener("click", llamadaAjax);

}



function llamadaAjax() {
    //alert("Hola Mundo");

    var llamadaAjax = new XMLHttpRequest();

    llamadaAjax.open("GET", "http://localhost:61375/server/holaMundo.html");

    llamadaAjax.onreadystatechange = function () {

        if (llamadaAjax.readyState < 4) {

        }
        else {

            if (llamadaAjax.readyState == 4 && llamadaAjax.status == 200) {

                var response = llamadaAjax.responseText;

                document.getElementById("respuesta").innerHTML = response;

            }

        }

    };

    llamadaAjax.send();

}