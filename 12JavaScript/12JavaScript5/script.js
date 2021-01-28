window.onload = function(){

    var hoursDiv = document.getElementById("hours");
    var minutesDiv = document.getElementById("minutes");
    var secondsDiv = document.getElementById("seconds");
    var twoPoints1Div = document.getElementById("twoPoints1");
    var twoPoints2Div = document.getElementById("twoPoints2");

    var twoPoints = document.createElement("img");
    twoPoints.src = "imgs/dosPuntos.gif";
    twoPoints1Div.appendChild(twoPoints);
    var twoPoints = document.createElement("img");
    twoPoints.src = "imgs/dosPuntos.gif";
    twoPoints2Div.appendChild(twoPoints);

    
    //alert(horaActual);



    setInterval(function(){ 
        var actualDate = new Date();
        var actualTime = [actualDate.getHours(), actualDate.getMinutes(), actualDate.getSeconds()];
        timeToImg(actualTime, hoursDiv, minutesDiv, secondsDiv)
    }, 1000);

    //timeToImg(actualTime, hoursDiv, minutesDiv, secondsDiv);
}

function timeToImg(actualTime, hoursDiv, minutesDiv, secondsDiv){
    hoursToImg(actualTime[0], hoursDiv);
    minutesToImg(actualTime[1], minutesDiv);
    secondsToImg(actualTime[2], secondsDiv);
}

function hoursToImg(hours, div){

    div.innerHTML = "";

    if(hours<10){

        var img = document.createElement("img");
        img.src = "imgs/0.gif";
        div.appendChild(img);
        
        img = document.createElement("img");
        img.src = "imgs/"+hours+".gif";
        div.appendChild(img);
 
    }else{

        var img = document.createElement("img");
        img.src = "imgs/"+hours.toString()[0]+".gif";
        div.appendChild(img);

        img = document.createElement("img");
        img.src = "imgs/"+hours.toString()[1]+".gif";
        div.appendChild(img);

    }
}

function minutesToImg(minutes, div){

    div.innerHTML = "";

    if(minutes<10){

        var img = document.createElement("img");
        img.src = "imgs/0.gif";
        div.appendChild(img);
        
        img = document.createElement("img");
        img.src = "imgs/"+minutes+".gif";
        div.appendChild(img);
 
    }else{

        var img = document.createElement("img");
        img.src = "imgs/"+minutes.toString()[0]+".gif";
        div.appendChild(img);

        img = document.createElement("img");
        img.src = "imgs/"+minutes.toString()[1]+".gif";
        div.appendChild(img);

    }

}

function secondsToImg(seconds, div){

    div.innerHTML = "";

    if(seconds<10){

        var img = document.createElement("img");
        img.src = "imgs/0.gif";
        div.appendChild(img);
        
        img = document.createElement("img");
        img.src = "imgs/"+seconds+".gif";
        div.appendChild(img);
 
    }else{

        var img = document.createElement("img");
        img.src = "imgs/"+seconds.toString()[0]+".gif";
        div.appendChild(img);

        img = document.createElement("img");
        img.src = "imgs/"+seconds.toString()[1]+".gif";
        div.appendChild(img);

    }

}
