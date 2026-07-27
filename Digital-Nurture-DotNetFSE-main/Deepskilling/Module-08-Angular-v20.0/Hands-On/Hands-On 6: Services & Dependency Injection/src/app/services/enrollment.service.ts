import { Injectable, inject, computed } from '@angular/core';
import { CourseService } from './course.service';
import { NotificationService } from './notification.service';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {
  private courseService = inject(CourseService);
  private notificationService = inject(NotificationService);

  // Expose courses signal directly from CourseService for convenience
  readonly courses = this.courseService.courses;

  // Computed academic metrics based on Course Catalog state
  readonly totalCredits = computed(() => {
    return this.courses()
      .filter(c => c.status === 'enrolled' || c.status === 'completed')
      .reduce((sum, c) => sum + c.credits, 0);
  });

  readonly completedCoursesCount = computed(() => {
    return this.courses().filter(c => c.status === 'completed').length;
  });

  readonly enrolledCoursesCount = computed(() => {
    return this.courses().filter(c => c.status === 'enrolled').length;
  });

  readonly overallProgress = computed(() => {
    const activeCourses = this.courses().filter(c => c.status === 'enrolled' || c.status === 'completed');
    if (activeCourses.length === 0) return 0;
    const totalProgress = activeCourses.reduce((sum, c) => sum + c.progress, 0);
    return Math.round(totalProgress / activeCourses.length);
  });

  // Actions
  enrollInCourse(courseId: string) {
    const course = this.courseService.getCourseById(courseId);
    if (course) {
      this.courseService.updateCourse(courseId, {
        status: 'enrolled',
        progress: 0
      });
      this.notificationService.show(`Successfully enrolled in ${course.title}`, 'success');
    }
  }

  unenrollFromCourse(courseId: string) {
    const course = this.courseService.getCourseById(courseId);
    if (course) {
      this.courseService.updateCourse(courseId, {
        status: 'available',
        progress: 0
      });
      this.notificationService.show(`Unenrolled from ${course.title}`, 'warning');
    }
  }

  resumeCourse(courseId: string) {
    const course = this.courseService.getCourseById(courseId);
    if (course) {
      const nextProgress = Math.min(course.progress + 15, 100);
      const nextStatus = nextProgress === 100 ? 'completed' : 'enrolled';
      
      this.courseService.updateCourse(courseId, {
        progress: nextProgress,
        status: nextStatus
      });

      if (nextProgress === 100) {
        this.notificationService.show(`Congratulations! You completed ${course.title}`, 'success');
      } else {
        this.notificationService.show(`Resumed ${course.title} (Progress: ${nextProgress}%)`, 'info');
      }
    }
  }
}
