import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Course } from '../../models/course';

@Component({
  selector: 'app-course-card',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCardComponent {
  @Input({ required: true }) course!: Course;
  
  @Output() enroll = new EventEmitter<string>();
  @Output() resume = new EventEmitter<string>();

  onEnroll() {
    this.enroll.emit(this.course.id);
  }

  onResume() {
    this.resume.emit(this.course.id);
  }
}
