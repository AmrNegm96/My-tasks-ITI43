var btn =  document.getElementById("btn1")

var radiobtns =  document.getElementsByName("rd");

var image;
var text;
var page ;

var x;

btn.onclick = choose ;

function choose(){
    

    for(var i=0 ; i<radiobtns.length ; i++)
    {
        if(radiobtns[i].checked)
        {
            image = document.getElementById("img"+i).src ;
        }
    }

    text = document.getElementById("txt1").value ;

    
    var w = window.open("yourcard.html","","width=500, height=500");
    w.focus();

    

    w.onload = function(){

        var chosenImage = w.document.getElementById("imgchosen");
        var chosenText =  w.document.getElementById("para");
        var removeCard = document.getElementById("btn2");

        chosenImage.src = image ;

        chosenText.innerHTML ="<h1 style='color:dodgerblue;'>"+text+"</h1>" ;
        
         removeCard.onclick = function() {

            setTimeout(close(w),500)
        };
    };
};




