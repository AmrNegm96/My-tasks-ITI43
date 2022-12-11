var result = prompt("Please enter your heading" , "default");

function heading(){
    for ( i=0 ; i<6 ; i++)
    {
        document.write("<h" + (i+1) + ">" + result + "<h" + (i+1) + ">");
    }
}

heading();