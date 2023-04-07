import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HeaderComponent } from './Components/header/header.component';
import { HomeComponent } from './Components/home/home.component';
import { ErrorPageComponent } from './Components/error-page/error-page.component';
import { StudentsComponent } from './Components/students/students.component';
import { StudentsDetailsComponent } from './Components/students-details/students-details.component';
import { ValidationComponent } from './Components/validation/validation.component';
import { HttpClientModule } from '@angular/common/http'
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    ErrorPageComponent,
    StudentsComponent,
    StudentsDetailsComponent,
    ValidationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
