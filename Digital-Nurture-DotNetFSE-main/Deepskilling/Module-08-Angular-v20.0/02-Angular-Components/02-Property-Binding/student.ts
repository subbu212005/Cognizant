import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentName = "John Doe";
  department = "Computer Science";
  rollNumber = 101;
  isDisabled = false;

}
