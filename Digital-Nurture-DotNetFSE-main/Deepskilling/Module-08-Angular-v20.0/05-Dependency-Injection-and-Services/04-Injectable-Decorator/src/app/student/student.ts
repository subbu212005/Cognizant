import { Component } from '@angular/core';
import { StudentDataService } from '../student-data.service';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  info = '';

  constructor(private studentService: StudentDataService) {
    this.info = this.studentService.getStudentInfo();
  }

}
