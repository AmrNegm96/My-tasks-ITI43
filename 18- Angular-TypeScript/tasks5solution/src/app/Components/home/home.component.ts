import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: [
  ]
})
export class HomeComponent {

  @Output() HomeAddEvent = new EventEmitter();

  Add(name:string,age:string,email:string){
    let newStudent = {name:name , age:age , email:email };
    this.HomeAddEvent.emit(newStudent);
  }
  
}
