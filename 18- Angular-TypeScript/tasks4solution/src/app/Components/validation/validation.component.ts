import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-validation',
  templateUrl: './validation.component.html',
  styles: [
  ]
})
export class ValidationComponent {

  //we have to bind to the form and after this bind to the inputs 
  formValidation = new FormGroup({
    name: new FormControl("", Validators.minLength(5)),
    age: new FormControl("",[Validators.min(20) , Validators.max(40)]),
    email: new FormControl("",Validators.email),
  });

  // @Output() HomeAddEvent = new EventEmitter();
  // Add(name:string,age:string,email:string){
  //   let newStudent = {name:name , age:age , email:email };
  //   this.HomeAddEvent.emit(newStudent);
  // }
  
  get NameValid(){
    return this.formValidation.controls["name"].valid;
  }
  get AgeValid(){
    return this.formValidation.controls["age"].valid;
  }
  get EmailValid(){
    return this.formValidation.controls["email"].valid;
  }

  getValue(){
    // console.log(this.formValidation);
    // console.log(this.formValidation.controls["name"].valid);
    // console.log(this.formValidation.controls["age"].valid);
    // console.log(this.formValidation.controls["email"].valid);
    
  }

}
