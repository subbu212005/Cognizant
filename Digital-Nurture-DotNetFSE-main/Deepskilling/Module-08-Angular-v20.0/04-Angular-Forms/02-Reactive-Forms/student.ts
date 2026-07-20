import { Component } from '@angular/core';
import { ReactiveFormsModule, FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  studentForm = new FormGroup({
    name: new FormControl(''),
    email: new FormControl(''),
    course: new FormControl('')
  });

  onSubmit() {
    alert('Reactive Form Submitted Successfully!');
    console.log(this.studentForm.value);
  }

}
