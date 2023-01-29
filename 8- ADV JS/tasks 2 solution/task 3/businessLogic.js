document.getElementById("btn").onclick = function(){

    var userName = document.getElementById("userNameID").value;
    var userAge = document.getElementById("ageID").value;
    var userMale = document.getElementById("male");

    var usercolor = document.getElementById("color").value;
    
    setCookie( "name" , userName );
    setCookie( "Age" , userAge );
    setCookie( "color" , usercolor );
    setCookie("visits" , 0);
    userMale.checked ? setCookie( "gender" , "male" ) : setCookie( "gender" , "female" );
    

    window.location.assign("welcome.html");

}
    