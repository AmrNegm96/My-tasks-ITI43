function fun1()
{
    var strA = prompt("please enter a string" , "default");
    var Case = confirm("do you want to consider letter case");
    var count = 0 ; 
    var compare = true;
    var i;

    var strReverse = [];

for (i in strA)
    strReverse[i] = strA[i];

strReverse.reverse();

if(Case)
{
    for (i in strA) {
        if (strA[i] != strReverse[i])
            compare = false;
    
    }
    
    if (compare) {
        document.write("<h1> Is palindrome");
    }
    else {
        document.write("<h1> is not palindrome!");
    }
}
else
{

    for (i in strA) {
        if (strA[i].toLocaleLowerCase() != strReverse[i].toLowerCase())
            compare = false;
    }
   
    if(compare)
        document.write("the string is palindrom");
    else
        document.write("the string is not a palindrom");
}
    
}

fun1()


// var str = prompt("Please enter a string").split("");
// var strReverse = [];
// var flag = true;




// if (Case)
//     {   
//        for (i = strA.length-1 ; i>=0 ; --i)
//         {
//             if(strA[i] != strA[strA.length-i-1])
//                 compare = false;     
//         }

//         if(compare)
//             document.write("the string is palindrom");
//         else
//             document.write("the string is not a palindrom");
//     }
//     else
//     {
        

//         for (i = strA.length-1 ; i>=0 ; --i)
//         {
//             if(strA[i].toLowerCase() != strA[strA.length-i-1].toLowerCase())
//                 compare = false;     
//         }

//         if(compare)
//             document.write("the string is palindrom");
//         else
//             document.write("the string is not a palindrom");
//     }