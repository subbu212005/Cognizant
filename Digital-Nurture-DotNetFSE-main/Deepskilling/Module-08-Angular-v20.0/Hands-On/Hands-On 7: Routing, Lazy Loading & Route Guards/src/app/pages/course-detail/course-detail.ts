import { Component, inject, computed, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';

@Component({
  selector: 'app-course-detail',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './course-detail.html',
  styleUrl: './course-detail.css'
})
export class CourseDetailComponent {
  private route = inject(ActivatedRoute);
  private router = inject(Router);
  private courseService = inject(CourseService);
  enrollmentService = inject(EnrollmentService);

  courseId = signal<string | null>(null);

  course = computed(() => {
    const id = this.courseId();
    if (!id) return undefined;
    return this.courseService.getCourseById(id);
  });

  constructor() {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      this.courseId.set(id);
      if (id && !this.course()) {
        this.router.navigate(['/not-found'], { skipLocationChange: true });
      }
    });
  }

  enroll() {
    const current = this.course();
    if (current) {
      this.enrollmentService.enrollInCourse(current.id);
    }
  }

  resume() {
    const current = this.course();
    if (current) {
      this.enrollmentService.resumeCourse(current.id);
    }
  }

  unenroll() {
    const current = this.course();
    if (current) {
      this.enrollmentService.unenrollFromCourse(current.id);
    }
  }
}
