import { Component } from '@angular/core';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  message = '';

  constructor(private studentService: StudentService) {
    this.message = this.studentService.getMessage();
  }

}
