const http = require("http")
const fs = require("fs")



http.createServer((req,res)=>{
    if(req.url == "/favicon.ico"){

    }
    else{
        var reqUrlArr = req.url.split("/")
        switch(reqUrlArr[1]) {
            case "add":
                var result = parseInt(reqUrlArr[2])
              for(var i = 3 ; i<reqUrlArr.length ; i++){
                result+=parseInt(reqUrlArr[i])
              }
              res.write("<h1>result is "+result+"</h1>")
              break;
            case "subtract":
                var result = parseInt(reqUrlArr[2])
                for(var i = 3 ; i<reqUrlArr.length ; i++){
                    result-=parseInt(reqUrlArr[i])
                }
                res.write("<h1>result is "+result+"</h1>")
              break;
              case "multiply":
                var result = parseInt(reqUrlArr[2])
                for(var i = 3 ; i<reqUrlArr.length ; i++){
                    result*=reqUrlArr[i]
                }
                res.write("<h1>result is "+result+"</h1>")
              break;
              case "divide":
                var result = parseInt(reqUrlArr[2])
                for(var i = 3 ; i<reqUrlArr.length ; i++){
                    result/= parseInt(reqUrlArr[i])
                }
                res.write("<h1>result is "+result+"</h1>")
              break;
            }

        res.end()

        fs.appendFile("result.txt" ,result.toString()+"\n" , ()=>{} )
    }
}).listen(7000)