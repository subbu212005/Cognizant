import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  imports: [CommonModule, CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css',
})
export class CourseList {
  courses = [
    { id: 101, name: 'Introduction to Angular v20', code: 'CS-201', credits: 3 },
    { id: 102, name: 'Advanced TypeScript & Web Apps', code: 'CS-202', credits: 4 },
    { id: 103, name: 'Enterprise State Management with NgRx', code: 'CS-301', credits: 3 },
    { id: 104, name: 'Asynchronous Programming with RxJS', code: 'CS-302', credits: 3 },
    { id: 105, name: 'Unit Testing & Automated Quality Assurance', code: 'CS-401', credits: 4 }
  ];

  selectedCourseId: number | null = null;

  onEnroll(courseId: number): void {
    console.log('Enrolling in course: ' + courseId);
    this.selectedCourseId = courseId;
  }
}
