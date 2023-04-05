import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { HomeComponent } from './Components/home/home.component';
import { StudentsComponent } from './Components/students/students.component';
import { StudentsDetailsComponent } from './Components/students-details/students-details.component';
import { ErrorPageComponent } from './Components/error-page/error-page.component';
import { ValidationComponent } from './Components/validation/validation.component';
import { RoutingComponent } from './Components/routing/routing.component';
import { HeaderComponent } from './Components/header/header.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentsComponent,
    StudentsDetailsComponent,
    ErrorPageComponent,
    ValidationComponent,
    RoutingComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      {path:"" , component:HomeComponent},
      {path:"home" , component:HomeComponent},
      {path:"students" , component:StudentsComponent},
      {path:"students/:id" , component:StudentsDetailsComponent},
      {path:"**" , component:ErrorPageComponent},
      {path:"" , component:HomeComponent},
      {path:"" , component:HomeComponent},
      {path:"" , component:HomeComponent},
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
