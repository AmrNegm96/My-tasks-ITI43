import { Component } from '@angular/core';

@Component({
  selector: 'app-second',
  templateUrl: './second-component.component.html',
  styleUrls: ['./second-component.component.css']
})
export class SecondComponentComponent {
  images = ["assets/Images/1.jpg","assets/Images/2.jpg","assets/Images/3.jpg",
  "assets/Images/4.jpg","assets/Images/5.jpg"]
  
  imagePath = "assets/Images/1.jpg" ;
  counter=0;
  Interval:any;
  prev(){
    this.counter--;
    if(this.counter>=0 && this.counter<=this.images.length-1){
      this.imagePath=this.images[this.counter];
    }
    else if(this.counter<0) {
      this.counter=0;
      this.imagePath=this.images[this.counter];
    }
    console.log(this.counter);
    console.log(this.imagePath);
  }
  next(){
    this.counter++; //1
    if(this.counter>=0 && this.counter<=this.images.length-1){
      this.imagePath=this.images[this.counter];
    }
    else if(this.counter>4){
      this.counter=this.images.length-1;
      this.imagePath=this.images[this.counter];
    }
  }
  slide(){
   this.Interval = setInterval(() =>{
    this.counter++;
      if(this.counter>=0 && this.counter<=this.images.length-1){
        this.imagePath=this.images[this.counter];
      }
      else if(this.counter>4){
        this.counter=0;
        this.imagePath=this.images[this.counter];
      }
      else if(this.counter<0) {
        this.counter=this.images.length-1;
        this.imagePath=this.images[this.counter];
      }
    },1000)
  }
  stop(){
    clearInterval(this.Interval);
  }
}
