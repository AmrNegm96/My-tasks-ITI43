import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Router } from '@angular/router';
import { StudentsService } from 'src/app/Services/students.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styles: [
  ]
})
export class StudentsComponent implements OnChanges , OnInit {

  students:any;
  @Input() student:any;

  constructor(private myservice:StudentsService , private router:Router){}
  ngOnInit(): void {
    this.myservice.getAllstudents().subscribe(
      {
        next:(data)=>{
          this.students = data;
        } ,
        error:(err)=>{ }
      }
    );
  }
  delete(id:number){
    this.myservice.DeleteStudentById(id).subscribe({});
    this.router.navigate(['/students']);
  }

  ngOnChanges(changes: SimpleChanges): void {

  }

  /**
   * ctor
   * ngOnChanges
   * ngOnInit
   * ngDoCheck
   *
   *
   *
   *
   * ngOnDestroy
   */
}
