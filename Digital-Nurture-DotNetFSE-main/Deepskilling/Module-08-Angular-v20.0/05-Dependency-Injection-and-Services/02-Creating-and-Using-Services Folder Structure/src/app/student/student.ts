import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentDataService } from '../student-data.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  students: string[] = [];

  constructor(private studentService: StudentDataService) {
    this.students = this.studentService.getStudents();
  }

}
