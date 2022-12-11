var page;
var widthMax  = window.screen.width;
var heightMax = window.screen.height;
var  tempH = 0;
var  tempW = 0;
var flag = true;
var t;

function fun1()
{
    document.write("<h1>I am the parent window.</h1> <hr>".fontcolor("blue"))
}  



function openwin()
{

    page = open("childpage.html","","width=200 , height=200");
    page.focus();


    t = page.setInterval(function () {
        page.resizeTo(200,200);
        if (flag) {
            
            if (tempH >= heightMax-300  || tempW >= widthMax-300)
                flag = false;
            tempH += 10;
            tempW += 10;
            page.moveBy(10, 10);
        } else {
            if (tempH <= 50 || tempW <= 50)
                flag = true;
            tempH -= 10;
            tempW -= 10;
            page.moveBy(-10, -10);
        }
    }
    , 30);
}


function closewin()
{
    page.clearInterval(t);
    page.focus();
    page.setTimeout(function(){page.close();},3000);
}

fun1();

/*

    
    while(flag){
        
        var t1 = setInterval(function(){
            if(tempH <= heightMax-300)
            {
                page.moveBy(10,10)
                tempW+=10;
                tempH+=10;
            }
        },10)
            
            clearInterval(t1);
    
        var t2 = setInterval(function(){
            
            if(tempH > heightMax)
            {
                page.moveBy(-10,-10)
                tempW-=10;
                tempH-=10;
            }
        },10) 
            
            clearInterval(t2);

    }
    
        
         
}*/






