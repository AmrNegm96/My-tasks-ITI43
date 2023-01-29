var c2 = document.getElementById("c2");
var ctx2 = c2.getContext("2d");

// Create gradient
var grd = ctx2.createLinearGradient(0, 0, 0,150 );
grd.addColorStop(0, "green");
grd.addColorStop(1, "white");

// Fill with gradient
ctx2.fillStyle = grd;
ctx2.fillRect(0, 0, 500, 150);



var c1 = document.getElementById("c1");
var ctx1 = c1.getContext("2d");

// Create gradient
var grd = ctx1.createLinearGradient(0, 0, 0,150 );
grd.addColorStop(0, "cyan");
grd.addColorStop(1, "white");

// Fill with gradient
ctx1.fillStyle = grd;
ctx1.fillRect(0, 0, 500, 150);



var c2 = document.getElementById("c3");
var ctx3 = c3.getContext("2d");
ctx3.beginPath()
ctx3.moveTo(150,0);
ctx3.lineTo(150, 100);
ctx3.strokeStyle="black"
ctx3.stroke();
ctx3.closePath();

ctx3.beginPath()
ctx3.moveTo(350,0);
ctx3.lineTo(350, 100);
ctx3.strokeStyle="black"
ctx3.stroke();
ctx3.closePath();

ctx3.beginPath()
ctx3.moveTo(150,0);
ctx3.lineTo(350, 0);
ctx3.strokeStyle="black"
ctx3.stroke();
ctx3.closePath();




