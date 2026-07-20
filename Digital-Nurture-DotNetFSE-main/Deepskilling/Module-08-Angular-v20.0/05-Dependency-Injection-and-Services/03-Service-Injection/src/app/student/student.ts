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

  college = '';

  constructor(private studentService: StudentDataService) {
    this.college = this.studentService.getCollegeName();
  }

}
