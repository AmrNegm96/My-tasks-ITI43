import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'FisrtAngularProject';
  name:string = "";
  age:string ="";
  Parentstudents:{name:string , age:string}[] = []
  getDatatoParent(data:any){
    console.log(data);
    this.Parentstudents.push(data) ;
  }
}
