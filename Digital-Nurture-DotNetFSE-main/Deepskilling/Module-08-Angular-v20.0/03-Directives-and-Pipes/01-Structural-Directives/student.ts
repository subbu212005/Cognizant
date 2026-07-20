import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  isLoggedIn = true;

  students = [
    'John',
    'Rahul',
    'Priya',
    'Anjali'
  ];

  role = 'Student';

}
