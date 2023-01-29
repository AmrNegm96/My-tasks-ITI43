var img = new Image();
img.src = "11.jpg"

var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

img.onload=function(){

    ctx.drawImage(img,0,0,canvas.width,canvas.width);

    
    ctx.font = "36px georgia";
    ctx.strokeStyle = "white"
    ctx.fillStyle = "white"

    ctx.fillText("Hello World, look at my hoody", 11, 453);
    ctx.strokeText("Hello World, look at my hoody", 10, 450);
    
}

