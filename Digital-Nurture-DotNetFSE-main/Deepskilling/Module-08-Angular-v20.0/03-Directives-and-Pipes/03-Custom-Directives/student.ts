import { Component } from '@angular/core';
import { HighlightDirective } from '../highlight/highlight';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [HighlightDirective],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {
}
