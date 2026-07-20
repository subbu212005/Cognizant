import { Component } from '@angular/core';
import {
  ReactiveFormsModule,
  FormGroup,
  FormControl,
  Validators
} from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentForm = new FormGroup({
    name: new FormControl('', [
      Validators.required,
      Validators.minLength(3)
    ]),
    email: new FormControl('', [
      Validators.required,
      Validators.email
    ]),
    course: new FormControl('', [
      Validators.required
    ])
  });

  onSubmit() {
    if (this.studentForm.valid) {
      alert('Form Submitted Successfully!');
      console.log(this.studentForm.value);
    }
  }
}
