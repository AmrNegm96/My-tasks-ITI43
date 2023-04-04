var tbody= document.getElementsByTagName('tbody')[0];

fetch('http://localhost:7008/getRealdata').then((data =>{
//console.log(data);
//console.log(data.json());
    return data.json();
})).then(data => {

    console.log(data);
    
    for(let d of data){
        
        console.log(d);
        let Row = tbody.insertRow();

        let CName = Row.insertCell();
        let Cmobile = Row.insertCell();
        let Caddress = Row.insertCell();
        let Cemail = Row.insertCell();
        
        let Name = document.createTextNode(d.name);
        let mobile = document.createTextNode(d.mobile);
        let address = document.createTextNode(d.address);
        let email = document.createTextNode(d.email);

        CName.appendChild(Name);
        Cmobile.appendChild(mobile);
        Caddress.appendChild(address);
        Cemail.appendChild(email);
    }
});