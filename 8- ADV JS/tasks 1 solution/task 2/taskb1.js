

var fun2 = function()
{
    var Arr = [] ; 
    return Arr.reverse.apply(arguments);
}
let result2 = fun2(10,20,30,40,50,60,70,80,90,100);
console.log(result2);

/////////////////////////////////////////////////////////////////////////////////////////////////

function fun1 () {

    return Array.from(arguments).reverse() ;
}

let result1 = fun1(1,2,3,4,5,6,7,8,9,10);
console.log(result1);



//////////////////////////////////////////////////////////////////////////////////////////////

function fun3 (a,b){

    if(arguments.length>2)
    {
        throw new RangeError ("You must use only 2 arguments");
    }

}

//////////////////////////////////////////////////////////////////////////////////////////////////

var add = function (a, b) {

    var sum = 0;

    for (var i = 0; i < arguments.length; i++) {
        if(!isNaN(arguments[i]))
        {
            sum += arguments[i];
        }
        else
        {
            throw new TypeError ("Please enter only numeric values");
        }
            
    }
    return sum;
}

console.log(add(1,2))
console.log(add(1,2,3))
console.log(add(1,2,3,4))

