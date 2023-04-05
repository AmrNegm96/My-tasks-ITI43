const http = require("http");
const fs = require("fs");

let mainHtml = fs.readFileSync("../client/main.html").toString();
let welcomeHtml = fs.readFileSync("../client/welcome.html").toString();
let allDataHtml = fs.readFileSync("../client/alldatapage.html").toString();
let favIcon = fs.readFileSync("../favicon_io/favicon.ico");

const JsonData = fs.readFileSync('data.json').toString();

let bootStrapCss = fs.readFileSync('../node_modules/bootstrap/dist/css/bootstrap.min.css').toString();
let bootStrapJs = fs.readFileSync('../node_modules/bootstrap/dist/js/bootstrap.min.js').toString();

let DataRequestJs = fs.readFileSync("../client/DataRequest.js").toString();


http.createServer((req,res)=>{
    if(req.method === "GET"){
        console.log("get"+req.url);
        switch(req.url){
            case '/':
            case '/main.html':
            case '/client/main.html':
                res.write(mainHtml);
            break;
            case '/welcome.html':
            case '/client/welcome.html':
                res.write(welcomeHtml);
            break;
            case '/node_modules/bootstrap/dist/css/bootstrap.min.css':
                res.write(bootStrapCss);
            break;
            case '/node_modules/bootstrap/dist/js/bootstrap.min.js':
                res.write(bootStrapJs);
            break;
            case '/favicon.ico':
            case '/client/favicon.ico':
                res.write(favIcon);
            break;
            case '/DataRequest.js':
                res.write(DataRequestJs);
            break;
            case '/getRealdata':
                res.write(JsonData);
            break;    
        }
        res.end();
    }
    else if(req.method === "POST"){
        console.log("post"+req.url);
        switch(req.url){
            case '/':
            case '/welcome.html':
            case '/client/welcome.html':
                let name , address , email , mobile ;
                req.on("data" , (reqData)=>{
                    //console.log(reqData.toString());  name=amr+sherif&mobile=0111111111&address=abc&email=024578693145
                    let dataArr = reqData.toString().replaceAll("+"," ").split("&");
                    //console.log(dataArr) ['name=amr sherif','mobile=0111111111','address=abc','email=asas']
                    name = dataArr[0].split("=")[1];
                    mobile = dataArr[1].split("=")[1];
                    address = dataArr[2].split("=")[1];
                    email = dataArr[3].split("=")[1].replace("%40" , "@");

                    let newData = {
                        name,
                        mobile,
                        address,
                        email
                    }
                    //console.log(newData); {name: 'amr sherif',mobile: '01234567899',address: 'abc xyz',email: 'asas'}
                    const myFileData = JSON.parse(JsonData);
                    myFileData.push(newData);
                    const updatedData = JSON.stringify(myFileData);
                    fs.writeFileSync('data.json' , updatedData)
                });

                req.on("end" , ()=>{
                    res.write(
                        welcomeHtml
                        .replace("{Name}", name)
                        .replace("{Address}", address)
                        .replace("{email}", email)
                        .replace("{Mobile}", mobile)
                    )
                res.end();
                });

            break;  
            case '/alldatapage.html':
                res.write(allDataHtml);
                res.end();
            break;  
        }
    }
    
}).listen(7000 , ()=>{console.log("listening on port 7000")});