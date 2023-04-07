import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { StudentsService } from 'src/app/Services/students.service';

@Component({
  selector: 'app-students-details',
  templateUrl: './students-details.component.html',
  styles: [
  ]
})
export class StudentsDetailsComponent implements OnInit {

  student:any;
  ID:any;
  constructor(myyactivate:ActivatedRoute , private myService:StudentsService){
    this.ID = myyactivate.snapshot.params["id"]
  }
  ngOnInit(): void {
    this.myService.getDtudentById(this.ID).subscribe({
      next:(data)=>{
        this.student = data ;
      },
      error:()=>{}
    });
  }
}
