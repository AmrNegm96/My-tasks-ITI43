var page;

function fun1()
{
    document.write("<h1>I am the parent window.</h1> <hr>".fontcolor("blue"))
}  


    

function openwin()
{
    var  tempH = 0 ;

    page = open("childpage2.html","","width=400 , height=300");
    page.focus();
    page.moveTo(500,0);
    var t = page.setInterval(function(){
        if(tempH>=page.screen.height+1000) ///// ??????? 
        {
            clearInterval(t);
            setTimeout(function(){closewin();},3000) 
        }
        else
        {
            page.scrollBy(0, 10);
            tempH = tempH + 10;
        }
    },100);
    
}


function closewin()
{
    page.close();
}


fun1();
