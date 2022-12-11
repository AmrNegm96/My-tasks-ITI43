var imageArr = new Array;

imageArr[0] = new Image()
imageArr[0].src="image/1.jpg";

imageArr[1] = new Image()
imageArr[1].src="image/2.jpg";

imageArr[2] = new Image()
imageArr[2].src="image/3.jpg";

imageArr[3] = new Image()
imageArr[3].src="image/4.jpg";

imageArr[4] = new Image()
imageArr[4].src="image/5.jpg";

imageArr[5] = new Image()
imageArr[5].src="image/6.jpg";

var currentImg = 0 ;
var t ;

function nextbtnclick()
{
    if(currentImg<imageArr.length-1)
    {
        currentImg++;
        document.images[0].src = imageArr[currentImg].src;   
    }
    else
    {
        alert("there is no more images");
    }
}

function prevbtnclick()
{
    if(currentImg > 0)
    {
        currentImg--;
        document.images[0].src = imageArr[currentImg].src; 
    }
    else
    {
        alert("there is no more images")
    }
}

function slideshow()
{
    t= window.setInterval(function(){
        if(currentImg<imageArr.length-1)
        {
            currentImg++;
            document.images[0].src = imageArr[currentImg].src;
        }
        else if(currentImg == imageArr.length-1)
        {
            currentImg=0;
            document.images[0].src = imageArr[currentImg].src;
        }
        else if (currentImg==0)
        {   
            currentImg=imageArr.length-1;
            document.images[0].src = imageArr[currentImg].src;
        }
    },1000)
}

function stopshow()
{
    clearInterval(t);
    document.images[0].src = imageArr[currentImg].src;
}