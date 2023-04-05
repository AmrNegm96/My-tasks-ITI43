import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FisrtAngularProject';
  //students:{name:string , age:string , email:string}[]=[];
  singleStudent:any ;
  getData(data:any){
    this.singleStudent = data;
  }
}
