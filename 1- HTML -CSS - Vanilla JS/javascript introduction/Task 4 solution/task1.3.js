

function fun1()
{
    var str = prompt("please enter the string");
var arr = str.split(" ");

var count = 0 ;
var max=0;
var index;

for(i=0 ; i < arr.length ; i++)
{
    var temp = arr[i].length;
    if (temp > max)
    {
        max = temp;
        index = i;
    }
}

document.write("the longest word is '"+arr[index]+"' it consists of '"+max+"' characters");

}

fun1();
