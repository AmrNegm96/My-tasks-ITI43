import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  constructor(private readonly myClient:HttpClient) {}

  private readonly URL = "http://localhost:3000/students";

  getAllstudents(){
    return this.myClient.get(this.URL);
  }
  getDtudentById(id:any){
    return this.myClient.get(this.URL+"/"+id);
  }
  AddNewStudent(student:any)
  {
    return this.myClient.post(this.URL , student);
  }
  UpdateStudentById(id:number , student:any)
  {
    return this.myClient.put(this.URL+"/"+id , student);
  }
  DeleteStudentById(id:number)
  {
    return this.myClient.delete(this.URL+"/"+id);
  }
}
