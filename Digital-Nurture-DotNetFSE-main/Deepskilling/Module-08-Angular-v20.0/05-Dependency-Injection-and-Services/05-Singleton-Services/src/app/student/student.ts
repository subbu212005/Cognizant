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

  count = 0;

  constructor(private studentService: StudentDataService) {}

  increaseCount(): void {
    this.studentService.increment();
    this.count = this.studentService.getCount();
  }

}
