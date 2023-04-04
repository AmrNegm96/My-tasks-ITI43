use ITI

db.createCollection("Teachers")

db.Teachers.insertOne({_id:1 , name:"amr negm" , age:27 , salary: 1000 })

// no error produced from insertin instuctors w/o Fname or Lname

db.Teachers.find()

let teachersArr = [{_id:6,firstName:"noha",lastName:"hesham",
                age:21,salary:3500,
                address:{city:"cairo",street:10,building:8},
                courses:["js","mvc","signalR","expressjs"]},
                
                {_id:7,firstName:"mona",lastName:"ahmed",
                age:21,salary:3600,
                address:{city:"cairo",street:20,building:8},
                courses:["es6","mvc","signalR","expressjs"]},
                
                {_id:8,firstName:"mazen",lastName:"mohammed",
                age:21,salary:7040,
                address:{city:"Ismailia",street:10,building:8},
                courses:["asp.net","mvc","EF"]},
                
                {_id:9,firstName:"ebtesam",lastName:"hesham",
                age:21,salary:7500,
                address:{city:"mansoura",street:14,building:3},
                courses:["js","html5","signalR","expressjs","bootstrap"]}]
                
db.Teachers.insertMany(teachersArr)

//
// question d
//


db.Teachers.find()

db.Teachers.find({},{firstName:1 , lastName:1 , address:1})

db.Teachers.find({age:21} , {firstName:1 , address:{city:1}})
db.Teachers.find({age:21}, {firstName:1, "address.city": 1})


db.Teachers.find({"address.city" : "mansoura"} , {firstName:1 , age:1})

db.Teachers.find({firstName:"mona"},{lastName:"ahmed"},{firstName:
1,lastName:1})  

// because find takes 2 parameters and so the third parameter is not used and the second parameter was not true or false so it overrides the result




db.Teachers.find({courses:"mvc"},{firstName:1,courses:1})  
//courses array include "mvc", show first name and courses

/////////////////////////////////////////////////////////////////////////////



db.Teachers.find()

db.Teachers.find({salary:{$gt:4000}} , {firstName:1 , salary:1})

db.Teachers.find({age:{$lte:25}})

db.Teachers.find({"address.city":"mansoura" , "address.street" : {$in:[10,14]}} , {firstName:1 ,"address.city":1 , salary:1})

db.Teachers.find({courses:{$all:["js" , "jquery"]}}) 
db.Teachers.find({$and: [{courses:"js"}, {courses: "jquery"}]})


db.Teachers.find({courses:{$exists:true}}).forEach(i=>{
    print(`${i.firstName} , courses: ${i.courses.length}`)
})
    
db.Teachers.find({ firstName: { $exists: true }, lastName: { $exists: true }}, { _id: 0, firstName: 1, lastName: 1, age: 1 })
.sort({ firstName: 1, lastName: -1})
.forEach(ins => { 
print(ins.firstName + " " + ins.lastName + ", age " + ins.age)
})


db.Teachers.find({$or:[{firstName:"mohammed"},{lastName:"mohammed"}]})

db.Teachers.deleteOne( { $and: [ { firstName: "ebtesam"} , {courses: {$size: 5} } ] } )

db.Teachers.updateMany({},{$set:{active:true}})

db.Teachers.find()

db.Teachers.updateOne({$and: [{firstName: "mazen"}, {lastName: "mohammed"}, {courses: "EF"}]}, {$set: {"courses.$": "jquery"}})


db.Teachers.updateOne({$and: [{firstName: "noha"}, {lastName: "hesham"}]}, {$addToSet: {"courses": "jquery"}})

db.Teachers.updateOne({$and: [{firstName: "mazen"}, {lastName: "mohammed"}]}, {$unset: {salary: "dummy"}})


db.Teachers.updateMany({courses: {$size: 3}}, {$inc: {salary: -500}})

db.Teachers.updateMany({}, {$rename: {address: "fullAddress"}})

db.Teachers.updateOne({$and: [{firstName: "noha"}, {lastName: "hesham"}]}, {$set: {"fullAddress.street": 20}})

