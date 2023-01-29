var browser = navigator.userAgent.toString().toLowerCase();

if(browser.indexOf("chrome") === -1)
    alert("For better experience use chrome as your browser");

var querystrings = window.location.search.split("&");

var name = querystrings[0].substring(6,querystrings[0].length) ;

name = name.replace(/(\+)/g, " ");

var email = querystrings[1].substring(6,querystrings[1].length) ;
email = email.replace("%40" , "@");

var password = querystrings[2].substring(9,querystrings[2].length);

var jobtitle = querystrings[3].substring(9,querystrings[3].length);
jobtitle = jobtitle.replace(/(\+)/g, " ");

var mobile = querystrings[4].substring(7,querystrings[4].length);

var gender = querystrings[5].substring(7,querystrings[5].length);

var address = querystrings[6].substring(8,querystrings[6].length);
address = address.replace(/(\+)/g," ");

document.write("<h2>Hello '"+name+"' your job title is '"+jobtitle+"' , your email is '"+email+"' , your mobile is '"+mobile+"' , your gender is '"+gender+"' & your address is '"+address+"'</h2>");



    