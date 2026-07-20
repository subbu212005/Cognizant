import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentId = '';

  constructor(private route: ActivatedRoute) {
    this.studentId = this.route.snapshot.paramMap.get('id') ?? '';
  }

}
