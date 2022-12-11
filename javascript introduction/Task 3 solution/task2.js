
var sum=0;

while( num1 != 0 && sum <=100 )
{
    
    var num1 = prompt("please enter a number");
    
    if(isNaN(num1))
    {

        document.write("not a number <br>");
        num1=0;
        
    }
    else 
    {
        
        sum=sum+parseInt(num1);
        
    }
}
document.write("the sum is : " +sum);
