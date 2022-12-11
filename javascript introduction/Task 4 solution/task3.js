function fun1()
{
    var radius = parseInt(prompt("please enter radius"));
    var cArea = (Math.PI)*(Math.pow(radius,2));
    alert("the area is: "+cArea);

    var num = parseInt(prompt("please enter a number to get its squared root"));
    var sqroot = Math.sqrt(num);
    alert("the square root is: "+sqroot);

    var ang = parseInt(prompt("please enter an angle to calculate cosine of it"));
    var radang = (ang / 180)*(Math.PI) ;
    var cosN = Math.cos(radang);
    alert("the cosine is: "+cosN.toFixed(4));
}

fun1();