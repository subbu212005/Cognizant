import { Injectable, inject } from '@angular/core';
import { Store } from '@ngrx/store';
import { CourseService } from './course.service';
import { EnrollmentActions } from '../store/enrollment/enrollment.actions';
import {
  selectTotalCredits,
  selectCompletedCoursesCount,
  selectEnrolledCoursesCount,
  selectOverallProgress
} from '../store/enrollment/enrollment.selectors';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {
  private store = inject(Store);
  private courseService = inject(CourseService);

  // Expose courses signal directly from CourseService for convenience
  readonly courses = this.courseService.courses;

  // Selected academic metrics backed by NgRx selectors
  readonly totalCredits = this.store.selectSignal(selectTotalCredits);
  readonly completedCoursesCount = this.store.selectSignal(selectCompletedCoursesCount);
  readonly enrolledCoursesCount = this.store.selectSignal(selectEnrolledCoursesCount);
  readonly overallProgress = this.store.selectSignal(selectOverallProgress);

  // Facade methods dispatching enrollment actions
  enrollInCourse(courseId: string) {
    this.store.dispatch(EnrollmentActions.enrollCourse({ courseId }));
  }

  unenrollFromCourse(courseId: string) {
    this.store.dispatch(EnrollmentActions.unenrollCourse({ courseId }));
  }

  resumeCourse(courseId: string) {
    this.store.dispatch(EnrollmentActions.resumeCourse({ courseId }));
  }
}
