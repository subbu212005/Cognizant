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

  name = 'angular framework';
  today = new Date();
  salary = 50000;
  percentage = 0.85;

  student = {
    id: 101,
    name: 'John',
    department: 'Computer Science'
  };

}
