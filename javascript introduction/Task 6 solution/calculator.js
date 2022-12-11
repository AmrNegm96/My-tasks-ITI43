var ans = document.getElementById("Answer");
var result="";

var divNumOpr = [];
var Left=0;
var Right=0;
var temp = 0;
var sum=0;

function EnterNumber(number)
{
    result = result + number;
    ans.value = result; 
}

function EnterClear()
{
    ans.value="";
    result ="";
    temp=0;
    sum=0;
}

function EnterOperator(operator)
{
    result = result + " " + operator + " " ;
    ans.value = result ;
}

function EnterEqual()
{

    divNumOpr = result.split(" "); 
    
    EnterClear()

    for(var i=0 ; i<divNumOpr.length ; i++)
    {
        if(divNumOpr[i]==="/" || divNumOpr[i]==="*")
        {
            temp=0;
            Left=divNumOpr[i-1];
            Right=divNumOpr[i+1];
            divNumOpr[i]==="/" ? temp = temp + (parseFloat(Left) / parseFloat(Right)) : temp = temp + (parseFloat(Left) * parseFloat(Right));
            divNumOpr[i-1] = temp ;
            divNumOpr[i+1] = 0 ;
            divNumOpr[i]=0;
        }
    }
    
    for(var i=0 ; i<divNumOpr.length ; i++)
    {
        if(divNumOpr[i]==="+" || divNumOpr[i]==="-")
        {
            temp=0;
            Left=divNumOpr[i-1];
            Right=divNumOpr[i+1];
            divNumOpr[i]==="+" ? temp = temp + (parseFloat(Left) + parseFloat(Right)) : temp = temp + (parseFloat(Left) - parseFloat(Right));
            divNumOpr[i-1] = temp ;
            divNumOpr[i+1] = 0 ;
            divNumOpr[i]=0;
        }
    }

    for(var i=0 ; i<divNumOpr.length ; i++)
    {
        sum = sum + parseFloat(divNumOpr[i]);
    }
    
    ans.value = sum ;
    sum=0;
}

/// 50 + 60 * 70 - 80 / 90   == 4249.111
/// LOOP on * / from end of divNumOpr
/// (/) l=80 r=90 ---> temp = temp + (80/90)
/// 50 + 60 * 70 - (8/9) 0 0
/// (*) l=60 r=70 ---> temp = temp + (60*70)  
/// 50 + (4200) 0 0 - (8/9) 0 0
/// LOOP on + - from start of divNumOpr
/// (+) l=50 r=4200 ---> temp = temp + (50+4200)
/// 4250 0 0 0 0 - (8/9) 0 0
/// (-) l=0 r=(8/9) ---> temp = temp + (0-(8/9)
/// if no operators sum all elemnts
/// 4250 0 0 0 0 (-8/9) 0 0 0
/// 4250+0+0+0+0+(-8/9)+0+0+0
/// temp = 4249.11111