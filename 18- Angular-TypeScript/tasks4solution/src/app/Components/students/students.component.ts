import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styles: [
  ]
})
export class StudentsComponent implements OnChanges {
  
  //@Input() studentsTable:any;
  studentsTable:{name:string ,age:string,email:string}[]=[]
  @Input() student:any;

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
    //if(changes["student"].currentValue){
    //if(!changes["student"].firstChange){
    if(this.student){
      this.studentsTable.push(this.student)
    }
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
