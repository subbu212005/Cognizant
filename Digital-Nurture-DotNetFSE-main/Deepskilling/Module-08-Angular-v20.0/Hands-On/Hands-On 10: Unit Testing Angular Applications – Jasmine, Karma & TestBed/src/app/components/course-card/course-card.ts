import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Course } from '../../models/course';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-course-card',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCardComponent {
  @Input({ required: true }) course!: Course;
  
  @Output() enroll = new EventEmitter<string>();
  @Output() resume = new EventEmitter<string>();
  @Output() unenroll = new EventEmitter<string>();
  @Output() delete = new EventEmitter<string>();

  onEnroll() {
    this.enroll.emit(this.course.id);
  }

  onResume() {
    this.resume.emit(this.course.id);
  }

  onUnenroll() {
    this.unenroll.emit(this.course.id);
  }

  onDelete() {
    this.delete.emit(this.course.id);
  }
}

