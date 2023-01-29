var visitCount = 0 ;

function getCookie(cookieName)
{
    if (arguments.length != 1)
    {
        throw RangeError("Number of parameters should be 1 which is cookie name");
    }
    if (allCookieList() == "")
    {
        throw Error("there are no cookies");
    }
    if (typeof(cookieName) != "string")
    {
        throw TypeError("The cookie name must be a string");
    }

    var name = cookieName+"=";

    var Arrofcookie = document.cookie.split(';');  

    for(var i=0 ; i<Arrofcookie.length; i++)
    {
        var v = Arrofcookie[i].trim() ;

        if(v.indexOf(name) == 0)
        {
            return v.substring(name.length , v.length);
        }
    }
    return "";
}

function setCookie(cookieName , cookieValue , expiryDate)
{
    if (arguments.length < 2)
    {
        throw RangeError("Number of parameters should be at least 2");
    }
        
    if (typeof(cookieName) != "string")
    {
        throw TypeError("The cookie name must be a string");
    }
    if (typeof(cookieValue) != "string")
    {
        throw TypeError("The cookie value must be a string");
    }
    if ( expiryDate > 7 )
    {
        throw RangeError("the maximum number of days is 7 days");
    }
        
    if(expiryDate)
    {
        var time = new Date();
        time.setTime(time.getTime() + (expiryDate*24*60*60*1000));
        document.cookie = cookieName + "=" + cookieValue + "; expires=" + time.toUTCString() ;
    }
    else
    {
        document.cookie = cookieName + "=" + cookieValue;
    } 
}

function deleteCookie(cookieName)
{
    if (arguments.length != 1)
    {
        throw RangeError("Number of parameters should be 1 which is cookie name");
    }
    if (allCookieList() == "")
    {
        throw Error("there are no cookies");
    }

    if (typeof(cookieName) != "string")
    {
        throw TypeError("The cookie name must be a string");
    }
    
    document.cookie = cookieName+"="+ "" +"; expires=Thu, 01 Jan 2000 00:00:00 UTC";
}

function allCookieList()
{
    //return all cookies in 1 string 
    var x = document.cookie ;
    return x ; 
}

function hasCookie(cookieName)
{
    if (arguments.length != 1)
    {
        throw RangeError("Number of parameters should be 1 which is cookie name");
    }

    if (typeof(cookieName) != "string")
    {
        throw TypeError("The cookie name must be a string");
    }
     
    var Username = getCookie(cookieName)

    if( Username == "")
    {
        return false;
    }
    else
    {
        return true;
    }
}









