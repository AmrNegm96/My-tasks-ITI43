import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  
  name:string = "";
  age:string ="";
  
  @Output() myevent = new EventEmitter();

  add(){
    let newStudent = {name:this.name , age:this.age}
    if(+this.age<=40 && +this.age>=20){
      this.myevent.emit(newStudent);
      this.name = "";
      this.age ="";
    }
  }
}
