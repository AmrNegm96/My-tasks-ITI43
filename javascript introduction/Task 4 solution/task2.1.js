
function fun1()
{
    arr = [];
    
    for (var i=0 ; i<3 ; i++)
    {
        arr.push(parseInt(prompt("enter number"+(i+1))));
    }

    document.write("sum of 3 values  ".fontcolor("red") + arr[0]+"+"+arr[1]+"+"+arr[2]+"="+(arr[0]+arr[1]+arr[2])+"<br>" );
    document.write("multiplication of 3 values  ".fontcolor("red") + arr[0]+"*"+arr[1]+"*"+arr[2]+"="+(arr[0]*arr[1]*arr[2])+"<br>"  );
    document.write("division of 3 values  ".fontcolor("red") + arr[0]+"/"+arr[1]+"/"+arr[2]+"="+(arr[0]/arr[1]/arr[2])+"<br>"  );

}
fun1()