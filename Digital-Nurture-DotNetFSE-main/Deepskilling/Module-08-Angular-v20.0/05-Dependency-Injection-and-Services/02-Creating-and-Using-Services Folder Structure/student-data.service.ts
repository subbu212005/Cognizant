import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  students = [
    'Subbu',
    'Rahul',
    'Anjali',
    'Kiran',
    'Priya'
  ];

  getStudents() {
    return this.students;
  }

}
