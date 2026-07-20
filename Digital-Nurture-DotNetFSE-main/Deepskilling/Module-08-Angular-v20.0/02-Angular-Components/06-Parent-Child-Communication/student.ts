import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  @Input()
  studentName: string = '';

}
