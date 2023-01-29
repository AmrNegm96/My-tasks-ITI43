var div = document.getElementById("header")
var list =document.getElementById("nav")
var src = document.images[0].src ;
var image0 = document.images[0];
var image1 = document.images[1];
var image2 = document.images[2];
var menu = document.getElementById("navigation");

var t = setInterval(function(){

    list.style.listStyleType = "circle" ;
    menu.style.position = "absolute"
    menu.style.top = "250"
    menu.style.left = "700"

    image0.parentNode.removeChild(image0) ;
    image1.src=src;
    image1.style.position = "absolute";
    image1.style.top =450;
    image1.style.left = 50;

    image2.src=src;
    image2.style.position = "absolute";
    image2.style.top = 0;
    image2.style.right = 50;
    
    div.appendChild(image1);
    div.appendChild(image2);

    clearInterval(t);
},5000)





// var clone1 = image.cloneNode(true);

// var clone2 = image.cloneNode(true);

// clone1.style.position = 'absolute' ;
// clone1.style.left = 50 ;
// clone1.style.right = 50 ;
