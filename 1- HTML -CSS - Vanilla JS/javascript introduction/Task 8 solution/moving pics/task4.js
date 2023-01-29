var image0 = document.images[0];
var image1 = document.images[1];
var image2 = document.images[2];

var movebtn = document.getElementById("stop/movebtn");
var resetbtn = document.getElementById("resetbtn");

var para1 = document.getElementById("p1");
var para2 = document.getElementById("p2");


movebtn.onclick = move;
resetbtn.onclick = reset;

var x = 0;
var going = true;
var motionT;
var moving = false;


function move() 
{

    
    if (moving) 
    {
        movebtn.innerText = "Move";
        moving = false;
        clearInterval(motionT);
        
    } 
    else 
    {
        movebtn.innerText = "Stop";
        moving = true;
        
        motionT = setInterval(function () 
        {
            if (going) 
            {
                if (x >= 420)
                    going = false;

                x += 10;
                image0.style.left = x + "px";
                image1.style.left = 460 - x + "px";
                image2.style.top = 460 - x + "px";
            } 
            else
            {
                if (x <= 30)
                    going = true;

                x -= 10;
                image0.style.left = x + "px";
                image1.style.left = 460 - x + "px";
                image2.style.top = 460 - x + "px";
            }
            para1.innerText = " " + image0.style.left;
            para2.innerText = " " + image1.style.left;

        }, 30);
    }
}

function reset() {
    image0.style.left = 20 + "px";
    image1.style.left = 450 + "px";
    image2.style.top = 470 + "px";
    x = 0;
}