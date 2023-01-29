var page;
var Arr = "hi, how are you. nice to meet you bro.";
Arr=Arr.split("");
var i=0;
function fun1()
{
    document.write("<h1>I am the parent window.</h1> <hr>".fontcolor("blue"))
}  


    

function openwin()
{
   
    page = open("childpage3.html","","width=800, height=300");
    page.focus();

    setTimeout(function(){page.document.write("<h1>I am child window. </h1><hr>");},10); ///500 x??? 

    var t = setInterval(function(){
        
        if(i>=Arr.length)
        {
            setTimeout(function(){closewin();},3000); 
            clearInterval(t) ;
            i=0;          
        }
        else
        {
            page.document.write(Arr[i]);
            i++;
        }
        },20);
}


function closewin()
{
    page.close();
}


fun1();
