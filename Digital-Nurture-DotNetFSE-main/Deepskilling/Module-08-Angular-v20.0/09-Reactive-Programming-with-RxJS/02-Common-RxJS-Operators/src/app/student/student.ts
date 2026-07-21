import { Component,OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentService } from './student.service';

@Component({
 selector:'app-student',
 standalone:true,
 imports:[CommonModule],
 templateUrl:'./student.html',
 styleUrl:'./student.css'
})
export class StudentComponent implements OnInit{
 students:any[]=[];
 error='';
 constructor(private service:StudentService){}
 ngOnInit(){
   this.service.getStudents().subscribe({
     next:data=>this.students=data,
     error:()=>this.error='Failed to load students'
   });
 }
}
