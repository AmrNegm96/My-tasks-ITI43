var obj= {

    getSetGen : function () {

        var keysOfanyObject = Object.keys(this) ;  


        for (var keyIndex in keysOfanyObject) 
        {
                                        var getter = "get" + keysOfanyObject[keyIndex]; 

                                        var setter = "set" + keysOfanyObject[keyIndex];

            this[getter] = ( ////////// we used [] because the property is string
                             ////////// this getName fires a function that has is given the iterator i
                             ////////// it returns a function that return this Name
                             ////////// we used iife because the of iteration and closure issue 
                             ////////// if i used the inner function only it will return undefined 
                             ////////// so we used a function that i excuted by default that contain a function that will retrun the function needed
                                        function(a){
                                            /// we will return function that will do the statement as prevent return of undefined 
                                            return function () {
                                                return this[keysOfanyObject[a]];
                                            };
                                        }
            )(keyIndex);

            this[setter] = ( ////////// we used [] because the property is string
                             ////////// this setName fires a function that has is given the iterator i
                             ////////// it returns a function takes a value as an argument and set value in Name
                             ////////// we used iife because the of iteration and closure issue 
                             ////////// if i used the inner function only it will return undefined 
                             ////////// so we used a function that i excuted by default that contain a function that will retrun the function needed
                                        function(a){
                                            return function (value) {
                                                this[keysOfanyObject[a]] = value ;
                                            }
                                        }
            )(keyIndex);
        }
    }
}

// var Dog = (function() {
//     var name = "defaut name";

//     var DogInner = function() {
//         this.getName = function() {
//             return name;
//         };

//         this.setName = function(value) {
//             name = value;    
//         };    
//     };

//     return DogInner;
// })(); // this does the trick

// var dog = new Dog();
// dog.name = "Frankenweenie";     // has no effect on the name in Dog object
// console.log(dog.getName());     // logs: defaut name
// dog.setName("Frankenweenie");   
// console.log(dog.getName());     // logs: Frankenweenie




var user1 = {Name: "amr", Age: 27 , Addr: "abc st."};

var user2 = {userName: "sherif", hobby: 'reading'};

var user3 = {Nickname: "ngm"};

obj.getSetGen.apply(user1);
obj.getSetGen.apply(user2);
obj.getSetGen.apply(user3);

console.log("the old name is "+ user1.getName());
user1.setName("ahmed")
console.log("the new name is "+user1.getName());

console.log("///////////////////////////////////////////////////////////////")


console.log("the old address is "+ user1.getAddr());
user1.setAddr("xyz st.")
console.log("the new address is "+user1.getAddr());

console.log("///////////////////////////////////////////////////////////////")

console.log("the old hobby is "+ user2.gethobby());
user2.sethobby("football")
console.log("the new hobby is "+user2.gethobby());

console.log("///////////////////////////////////////////////////////////////")


console.log("the old nickname is "+ user3.getNickname());
user3.setNickname("Negm")
console.log("the new nickname is "+user3.getNickname());