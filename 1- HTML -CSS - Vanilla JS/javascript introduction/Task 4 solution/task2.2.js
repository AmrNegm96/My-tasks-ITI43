function fun1()
{
    var arr = [];
    var arrASC = [];
    var arrDSC = [];
    
    // function ASC(a, b)
    // {
    //     return a - b
    // }

    // function DSC(a, b)
    // {
    //     return b - a
    // }
    
    for (var i=0 ; i<5 ; i++)
    {
        arr.push(prompt("enter number "+(i+1)));
    }

    for (var i=0 ; i<5 ; i++)
    {
        arrASC[i]=arr[i];
        arrDSC[i]=arr[i];
    }


    arrDSC.sort(function(a, b){return b - a});
    arrASC.sort(function(a, b){return a - b});

    document.write("You have entered those values: ".fontcolor("red"));

    for ( var i=0 ; i<5 ; i++)
    {
        document.write(arr[i]);
    }

    document.write("<br>");

    document.write("the values sorted desc. : ".fontcolor("red"));

    for ( var i=0 ; i<5 ; i++)
    {
        document.write(arrDSC[i]);
    }

    document.write("<br>");

    document.write("the values sorted asc. : ".fontcolor("red"));

    for ( var i=0 ; i<5 ; i++)
    {
        document.write(arrASC[i]);
    }
    
    document.write("<br>");

}
fun1()

