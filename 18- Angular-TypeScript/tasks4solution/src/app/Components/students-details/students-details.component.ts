import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-students-details',
  templateUrl: './students-details.component.html',
  styles: [
  ]
})
export class StudentsDetailsComponent {

  ID=0;
  constructor(myyactivate:ActivatedRoute){
    console.log(myyactivate.snapshot.params["id"]);
    this.ID = myyactivate.snapshot.params["id"]
  }
}
