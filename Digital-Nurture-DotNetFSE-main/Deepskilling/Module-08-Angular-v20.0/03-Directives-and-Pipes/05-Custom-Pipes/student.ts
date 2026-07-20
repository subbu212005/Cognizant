import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReversePipe } from '../reverse/reverse';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CommonModule, ReversePipe],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  message = 'Angular Framework';

}
