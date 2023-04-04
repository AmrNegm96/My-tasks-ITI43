import { Component } from "@angular/core";

@Component({
    selector:"app-first",
    templateUrl:"./First.component.html",
    styleUrls:["./First.component.css"]
})

export class FirstComponent{
    name:string = "ahmed";
    firstName:string ="";
    LastName:string ="";
    change(e:any){
        console.log(e.target.value);
        this.firstName = e.target.value  
    }
    reset(e:any){
        console.log(e);
        // e.value = "";
        this.firstName = ""  ;
        
    }
}