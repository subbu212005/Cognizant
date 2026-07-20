import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent {

  message = "";

  showMessage() {
    this.message = "Welcome to Angular Event Binding!";
  }

}
