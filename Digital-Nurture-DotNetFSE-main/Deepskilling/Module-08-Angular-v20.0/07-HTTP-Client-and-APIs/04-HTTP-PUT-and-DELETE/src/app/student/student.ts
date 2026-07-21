import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { StudentService } from './student.service';

@Component({
 selector:'app-student',
 standalone:true,
 imports:[CommonModule,FormsModule],
 templateUrl:'./student.html',
 styleUrl:'./student.css'
})
export class StudentComponent{
 name='subbu';
 email='yedula2005@gmail.com';
 response:any={};

 constructor(private service:StudentService){}

 updateStudent(){
  this.service.updateStudent(1,{name:this.name,email:this.email})
  .subscribe(res=>this.response=res);
 }

 deleteStudent(){
  this.service.deleteStudent(1)
  .subscribe(res=>this.response=res);
 }
}
