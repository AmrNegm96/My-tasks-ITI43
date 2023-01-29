var canva = document.getElementById("myCanva");
var ctx = canva.getContext('2d');

var w=0;
var h=0;

ctx.beginPath()
ctx.moveTo(0,0); 

var t = setInterval(function(){
    if(w<=canva.width && h<=canva.height)
    { 
        
        ctx.lineTo(w, h);
        ctx.strokeStyle="red"
        ctx.stroke();
        ctx.closePath();
        ctx.beginPath()
        ctx.moveTo(w,h); 
        w=w+10;
        h=h+10;
    }
    else
    {
        alert("animation end")
        clearInterval(t);
    }
},100);


