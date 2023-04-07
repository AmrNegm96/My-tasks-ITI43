import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { StudentsComponent } from './Components/students/students.component';
import { StudentsDetailsComponent } from './Components/students-details/students-details.component';
import { ErrorPageComponent } from './Components/error-page/error-page.component';
import { ValidationComponent } from './Components/validation/validation.component';

const routes: Routes = [
  {path:"Add" , component:ValidationComponent},
  {path:"" , component:StudentsComponent},
  {path:"students" , component:StudentsComponent},
  {path:"students/:id" , component:StudentsDetailsComponent},
  {path:"**" , component:ErrorPageComponent},
  {path:"" , component:ValidationComponent},
  {path:"" , component:ValidationComponent},
  {path:"" , component:ValidationComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
