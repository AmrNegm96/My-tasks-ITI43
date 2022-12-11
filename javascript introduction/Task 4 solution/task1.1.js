function fun1()
{
    var strA = prompt("please enter a string" , "default");

    var strB = prompt("please enter a character" , "default");

    var Case = confirm("do you want to consider letter case");

    var count = 0 ; 
    var i;

    if (Case)
    {
        for (i in strA)
        {
            if(strA[i] == strB)
                count++;
        }
        document.write("the count is:"+ count);
    }
    else
    {
        for (i in strA)
        {
            if(strA[i] == strB.toUpperCase() || strA[i] == strB.toLowerCase() )
                count++;
        }
        document.write("the count is:"+ count);
    }
}

fun1();