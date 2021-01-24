window.onload = function () {

    

    var btn = document.getElementById("btnPersona");

    btn.onclick = function (e) {
        //alert("BTN persona");
        llamadaAjax();
    };

    //btn.addEventListener("click", llamadaAjax);

}

function llamadaAjax() {

    var llamadaAjax = new XMLHttpRequest();

    llamadaAjax.open("GET", "https://fjmarquezcrudnet.azurewebsites.net/api/personas");

    llamadaAjax.onreadystatechange = function () {

        if (llamadaAjax.readyState < 4) {

        }
        else {

            if (llamadaAjax.readyState == 4 && llamadaAjax.status == 200) {

                var response = JSON.parse(llamadaAjax.responseText);

                document.getElementById("respuesta").innerHTML = response[0]['Apellidos'];

                //console.log(response[0]['Apellidos']);

            }

        }

    };

    llamadaAjax.send();

}