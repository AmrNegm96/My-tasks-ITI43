var img = document.images[0];


getCookie("gender") == "male" ?  img.src="image/1.jpg" : img.src="image/2.jpg" ;


window.onload = function(){
    
    setCookie("visits" , parseInt(getCookie("visits"))+1);

    var show = document.getElementById("text1");

    show.innerHTML = "welcome <span style= 'color:"+getCookie("color")+";'>"+getCookie("name")+
                "</span> you have visited the site <span style= 'color:"+getCookie("color")+";'>"+
                getCookie("visits")+"</span> times" ; 
}
