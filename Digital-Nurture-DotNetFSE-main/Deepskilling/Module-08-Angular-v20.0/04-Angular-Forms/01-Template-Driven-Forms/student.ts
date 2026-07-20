import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  student = {
    name: '',
    email: '',
    course: ''
  };

  onSubmit() {
    alert('Form Submitted Successfully!');
    console.log(this.student);
  }

}
