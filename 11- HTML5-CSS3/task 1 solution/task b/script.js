var red = document.getElementById("red");
var blue = document.getElementById("blue");
var green = document.getElementById("green");

var para = document.getElementById("text");


red.onchange = function () {
    para.style.color = "rgb("+red.value+","+green.value+","+blue.value+")" ;
}

blue.onchange = function () {
    para.style.color = "rgb("+red.value+","+green.value+","+blue.value+")" ;
}

green.onchange = function () {
    para.style.color = "rgb("+red.value+","+green.value+","+blue.value+")" ;
}