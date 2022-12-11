var randimg=0;

var flippedCards = 0;

var prevImg;
var nextImg;
var prevIndex;

var srcArr=["image/7.gif","image/7.gif","image/8.gif","image/8.gif",
            "image/9.gif","image/9.gif","image/10.gif","image/10.gif",
            "image/11.gif","image/11.gif","image/12.gif","image/12.gif"];

var randomArr = [];

for(var j=0 ; j<12 ; j++)
{
    randomArr[j] = srcArr[j]  ;
}

randomArr = randomArr.sort((a, b) => 0.5 - Math.random());

var i; 

function showphoto(img)
{   
    flippedCards++;

    if(flippedCards==1)
    {
        prevImg = img ;
        i = parseInt(img.id);
        img.src = randomArr[i];
        prevIndex = i;
    }
    if(flippedCards==2)
    {
        nextImg = img ;
        i = parseInt(img.id);
        img.src = randomArr[i];
        nextIndex = i;

        var t = setTimeout(function(){
        if( randomArr[prevIndex] != randomArr[nextIndex] )
        {
            prevImg.src="image/Moon.gif"
            nextImg.src="image/Moon.gif"
        }
            flippedCards = 0;
        },1000);
       
    }
    
}
