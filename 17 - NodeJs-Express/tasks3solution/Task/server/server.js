const express = require("express")
const app = express();
const bodyParser = require('body-parser');  // by7awel el data eli gya men el front asta2belha fel server
const path = require("path");
const fs = require("fs");

// console.log(process.env.port);
let PORT = process.env.port || 7008  //dynamic port
/*middle wares added here*/
//app.use(bodyParser.json()) // recieve json
app.use(bodyParser.urlencoded({extended:true})) //recieve from form
// add cors here
app.use((req, res, next) => {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE');
    res.setHeader('Access-Control-Allow-Headers', 'Content-Type');
    next();
});
/* custom middleware  we can make them for all requests or add it to certain request*/
// app.all('*' , function (req,res,next){
//     console.log("middle ware called")
//     next();
// })
// app.get('/' , function (req,res,next){
//     console.log("middle ware called")
//     res.send("Hello world");
// })

function main(req,res){
    res.sendFile(path.join(__dirname,"../client/main.html"));
}

function welcome(req,res){
    res.sendFile(path.join(__dirname,"../client/welcome.html"));
}

function fav(req,res){
    res.sendFile(path.join(__dirname,"../favicon_io/favicon.ico"));
}

app.get('/' , function (req,res){
    main(req,res);
})
app.get('/main.html' , function (req,res){
    main(req,res);
})
app.get('/client/main.html' , function (req,res){
    main(req,res);
})
app.get('/welcome.html' , function (req,res){
    welcome(req,res);
})
app.get('/client/welcome.html' , function (req,res){
    welcome(req,res);
})
app.get('/node_modules/bootstrap/dist/css/bootstrap.min.css' , function (req,res){
    res.sendFile(path.join(__dirname,"../node_modules/bootstrap/dist/css/bootstrap.min.css"));
})
app.get('/node_modules/bootstrap/dist/js/bootstrap.min.js' , function (req,res){
    res.sendFile(path.join(__dirname,"../node_modules/bootstrap/dist/js/bootstrap.min.js"));
})
app.get('/favicon.ico' , function (req,res){
    fav(req,res);
})
app.get('/client/favicon.ico' , function (req,res){
    fav(req,res);
})
app.get('/getRealdata' , function (req,res){
    res.sendFile(path.join(__dirname,"data.json"));
})
app.get('/DataRequest.js' , function (req,res){
    res.sendFile(path.join(__dirname,"../client/DataRequest.js"));
})
///////////////////////////////////////////////////////////////////


app.post('/welcome.html' , function (req,res){

        const formData = req.body;
        const html = fs.readFileSync("../client/welcome.html", "utf8");
        const responseHtml = html
          .replace("{Name}", formData.name)
          .replace("{Address}", formData.address)
          .replace("{email}", formData.email)
          .replace("{Mobile}", formData.mobile);
        
        let name = req.body.name;
        let mobile = req.body.mobile;
        let email = req.body.email;
        let address = req.body.address;

        let newData = {
            name,
            mobile,
            email,
            address
        }
        const myFileData = JSON.parse(fs.readFileSync('data.json').toString());
        myFileData.push(newData);
        const updatedData = JSON.stringify(myFileData);
        fs.writeFileSync('data.json' , updatedData);

        res.send(responseHtml);

    // console.log(req.body);
    //     //res.sendFile(path.join(__dirname,"../client/welcome.html"));
        
    //     // res.on('finish', () => {
    //     //     const modifiedData = fs.readFileSync('../client/welcome.html').toString()
    //     //     .replace("{Name}", Name).replace("{Address}", Address)
    //     //     .replace("{email}", Email).replace("{Mobile}", Mobile);

    //     //     fs.writeFileSync()
    //     //     res.send(modifiedData);
    //     // });
})


app.post('/alldatapage.html' , function (req,res){
    res.sendFile(path.join(__dirname,"../client/alldatapage.html"))
})


app.listen(PORT,()=>{console.log("http://www.localhost:"+PORT);})









// app.delete('/' , function (req,res){
    
// })
// app.patch('/' , function (req,res){
    
// })
// app.put('/' , function (req,res){
    
// })









