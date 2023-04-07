import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { StudentsService } from 'src/app/Services/students.service';

@Component({
  selector: 'app-validation',
  templateUrl: './validation.component.html',
  styles: [
  ]
})
export class ValidationComponent {

  constructor(private myservice:StudentsService , private router:Router){}

  Add(name:any,username:any,email:any,city:any){
    let newStudent = {
    "name": name,
    "username": username,
    "email": email,
    "address": {
      "street": null,
      "suite": null,
      "city": city,
      "zipcode": null
    }};
    this.myservice.AddNewStudent(newStudent).subscribe();
    this.router.navigate(['/students']);
  }


}
