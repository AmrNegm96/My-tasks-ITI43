var scA = document.getElementById("scA");
var scB = document.getElementById("scB");

var counter = 0 ;
scA.style.visibility = "visible"

var t = setInterval(function(){
    counter++;

    if(scA.style.visibility == "visible")
    {
        scA.style.visibility = "hidden"
        scB.style.visibility = "visible"
    }
    else if(scB.style.visibility == "visible")
    {
        scA.style.visibility = "visible"
        scB.style.visibility = "hidden"
    }
    if(counter==10)
    {
        clearInterval(t);
        scA.style.visibility = "visible"
        scB.style.visibility = "visible"
    }
} , 1000)