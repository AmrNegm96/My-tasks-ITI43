use FacultySystemV2

db.students.insertMany( 

[{_id:2,firstName:"sara",lastName:"mohamed",isFired:false,
        facultyID:1,Courses:[{courseID:1 , grade:10},{courseID:2 , grade:6},{courseID:3 , grade:8}]},
        {_id:3,firstName:"hala",lastName:"ahmed",isFired:false,
        facultyID:1,Courses:[{courseID:1 , grade:10},{courseID:2 , grade:5},{courseID:3 , grade:8}]},
        {_id:4,firstName:"khaled",lastName:"zaki",isFired:true,
        facultyID:1,Courses:[{courseID:1 , grade:4},{courseID:2 , grade:9},{courseID:3 , grade:6}]},
        {_id:5,firstName:"ahmed",lastName:"adel",isFired:false,
        facultyID:1,Courses:[{courseID:1 , grade:2},{courseID:2 , grade:8},{courseID:3 , grade:9}]},
        {_id:6,firstName:"salah",lastName:"ali",isFired:true,
        facultyID:1,Courses:[{courseID:1 , grade:10},{courseID:2 , grade:9},{courseID:3 , grade:8}]},
        {_id:7,firstName:"hazem",lastName:"nazmy",isFired:false,
        facultyID:1,Courses:[{courseID:1 , grade:10},{courseID:2 , grade:1},{courseID:3 , grade:5}]}]
        
)
        
db.students.find({})

db.createCollection("students" ,{
    validator:{
        $jsonSchema : {
            bsonType: "object",
            required: ["firstName","lastName","facultyID"],
            additionalProperties : false,
            properties :{
                _id :{
                    bsonType : "number"
                 },
                firstName:{
                    bsonType : "string"
                },
                lastName:{
                    bsonType:"string"
                },
                isFired:{
                    bsonType:"bool"
                },
                facultyID:{
                    bsonType:"number"
                },
                Courses:{
                    bsonType:["array"],
                    items:{
                        bsonType:"object",
                        required:["courseID" , "grade"],
                        properties:{
                            courseID:{
                                bsonType:"number"
                            },
                            grade:{
                                bsonType:"number"
                            }
                        }
                    }
                }
            }
        }
    }
})



db.faculty.insertMany( 

{_id:1,facultyName:"acb",address:"123 xyz st"}
        
)

db.faculty.find()


db.createCollection("faculty",{
    validator:{
        $jsonSchema:{
            bsonType:"object",
           // required:["facultyName" , "address"],
            properties:{
                _id:{
                    bsonType:"number"
                },
                facultyName:{
                    bsonType:"string"
                },
                address:{
                    bsonType:"string"
                }
            } 
        }

    }
})


db.courses.insertMany( 

[{_id:1,courseName:"course1",finalMark:10},
{_id:2,courseName:"course1",finalMark:10},
{_id:3,courseName:"course1",finalMark:10}]
        
)



db.createCollection("courses",{
    validator:{
        $jsonSchema:{
            bsonType:"object",
            required:["courseName" , "finalMark"],
            properties:{
                _id:{
                    bsonType:"number"
                },
                courseName:{
                    bsonType:"string"
                },
                finalMark:{
                    bsonType:"number"
                }
            } 
        }
    }
})

db.students.find()
db.faculty.find()
db.courses.find()


db.students.aggregate(
   [
      { $project: { fullName: { $concat: [ "$firstName", " ", "$lastName" ] },
          
                    grade :{$avg : ["$Courses.grade"]} 
                    } 
      }
   ]
)

db.courses.aggregate(
   [
      { $group: { _id: null,finalMarks: { $sum : "$finalMark" }}},
      { $project : {_id:0 , finalMarks:1}}
   ]
)

db.students.aggregate(
   [
      {
          $match : {firstName:"noha"}
      },
      {
          $lookup:{
              from:"courses",
              localField : "Courses.courseID",  //in student
              foreignField: "_id", // in course
              as: "StudentCourses" // alias
          }
      },
      {
          $project:{_id:0,isFired:0,Courses:0}
      }
   ]
)



db.students.aggregate(
   [
      {
          $match : {firstName:"noha"}
      },
      {
          $lookup:{
              from:"faculty",
              localField : "facultyID",  //in student
              foreignField: "_id", // in course
              as: "StudentFaculty" // alias  
          }
      },
      {
          $project:{_id:0,isFired:0,Courses:0,facultyID:0}
      }
   ]
)


db.students.createIndex({lastName:1} , {name:"lastNameIndex" , background:true }) // no block while making index

db.students.find({lastName:"mohamed"}).explain()


