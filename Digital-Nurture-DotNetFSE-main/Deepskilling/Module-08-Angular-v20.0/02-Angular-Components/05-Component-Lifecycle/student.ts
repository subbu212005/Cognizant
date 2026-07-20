import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class StudentComponent implements OnInit, OnDestroy {

  constructor() {
    console.log("Constructor Called");
  }

  ngOnInit(): void {
    console.log("ngOnInit Called");
  }

  ngOnDestroy(): void {
    console.log("ngOnDestroy Called");
  }

}
