move();

var currentMarble = 0;
var t;

function move()
{
    t=window.setInterval(function(){
        if(currentMarble<5)
        {   
            document.images[currentMarble].src = "image/marble1.jpg";
            currentMarble++;
            document.images[currentMarble].src = "image/marble2.jpg";
        }
        else if(currentMarble==5)
        {
            document.images[currentMarble].src = "image/marble1.jpg";
            currentMarble=0;
            document.images[currentMarble].src = "image/marble2.jpg";
        }    
    },300)
    
}

function stop()
{
    clearInterval(t);

}
function start()
{
    move();
}