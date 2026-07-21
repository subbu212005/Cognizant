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
 name='';
 email='';
 response:any;

 constructor(private service:StudentService){}

 submit(){
   const data={name:this.name,email:this.email};
   this.service.addStudent(data).subscribe(res=>this.response=res);
 }
}
