import { Injectable, inject } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { CourseService } from '../../services/course.service';
import { NotificationService } from '../../services/notification.service';
import { CourseActions } from './course.actions';
import { EnrollmentActions } from '../enrollment/enrollment.actions';
import { catchError, map, mergeMap, switchMap } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable()
export class CourseEffects {
  private actions$ = inject(Actions);
  private courseService = inject(CourseService);
  private notificationService = inject(NotificationService);

  loadCourses$ = createEffect(() =>
    this.actions$.pipe(
      ofType(CourseActions.loadCourses),
      switchMap(() =>
        this.courseService.loadCoursesApi().pipe(
          map(courses => CourseActions.loadCoursesSuccess({ courses })),
          catchError(error => of(CourseActions.loadCoursesFailure({ error: error.message || 'Failed to load courses' })))
        )
      )
    )
  );

  addCourse$ = createEffect(() =>
    this.actions$.pipe(
      ofType(CourseActions.addCourse),
      mergeMap(({ course }) =>
        this.courseService.addCourseApi(course).pipe(
          map(created => {
            this.notificationService.show(`Course "${created.title}" added successfully`, 'success');
            return CourseActions.addCourseSuccess({ course: created });
          }),
          catchError(error => of(CourseActions.addCourseFailure({ error: error.message || 'Failed to add course' })))
        )
      )
    )
  );

  updateCourse$ = createEffect(() =>
    this.actions$.pipe(
      ofType(CourseActions.updateCourse),
      mergeMap(({ courseId, updates }) =>
        this.courseService.updateCourseApi(courseId, updates).pipe(
          map(updated => CourseActions.updateCourseSuccess({ course: updated })),
          catchError(error => of(CourseActions.updateCourseFailure({ error: error.message || 'Failed to update course' })))
        )
      )
    )
  );

  deleteCourse$ = createEffect(() =>
    this.actions$.pipe(
      ofType(CourseActions.deleteCourse),
      mergeMap(({ courseId }) =>
        this.courseService.deleteCourseApi(courseId).pipe(
          map(() => {
            this.notificationService.show('Course deleted from catalog', 'warning');
            return CourseActions.deleteCourseSuccess({ courseId });
          }),
          catchError(error => of(CourseActions.deleteCourseFailure({ error: error.message || 'Failed to delete course' })))
        )
      )
    )
  );

  // Enrollment actions mapped to updates
  enrollCourse$ = createEffect(() =>
    this.actions$.pipe(
      ofType(EnrollmentActions.enrollCourse),
      mergeMap(({ courseId }) => {
        const course = this.courseService.getCourseById(courseId);
        if (!course) {
          return of(EnrollmentActions.enrollCourseFailure({ error: 'Course not found' }));
        }
        return this.courseService.updateCourseApi(courseId, { status: 'enrolled', progress: 0 }).pipe(
          map(updated => {
            this.notificationService.show(`Successfully enrolled in ${updated.title}`, 'success');
            return EnrollmentActions.enrollCourseSuccess({ course: updated });
          }),
          catchError(error => of(EnrollmentActions.enrollCourseFailure({ error: error.message || 'Failed to enroll' })))
        );
      })
    )
  );

  unenrollCourse$ = createEffect(() =>
    this.actions$.pipe(
      ofType(EnrollmentActions.unenrollCourse),
      mergeMap(({ courseId }) => {
        const course = this.courseService.getCourseById(courseId);
        if (!course) {
          return of(EnrollmentActions.unenrollCourseFailure({ error: 'Course not found' }));
        }
        return this.courseService.updateCourseApi(courseId, { status: 'available', progress: 0 }).pipe(
          map(updated => {
            this.notificationService.show(`Unenrolled from ${updated.title}`, 'warning');
            return EnrollmentActions.unenrollCourseSuccess({ course: updated });
          }),
          catchError(error => of(EnrollmentActions.unenrollCourseFailure({ error: error.message || 'Failed to unenroll' })))
        );
      })
    )
  );

  resumeCourse$ = createEffect(() =>
    this.actions$.pipe(
      ofType(EnrollmentActions.resumeCourse),
      mergeMap(({ courseId }) => {
        const course = this.courseService.getCourseById(courseId);
        if (!course) {
          return of(EnrollmentActions.resumeCourseFailure({ error: 'Course not found' }));
        }
        const nextProgress = Math.min(course.progress + 15, 100);
        const nextStatus = nextProgress === 100 ? 'completed' : 'enrolled';

        return this.courseService.updateCourseApi(courseId, { progress: nextProgress, status: nextStatus }).pipe(
          map(updated => {
            if (nextProgress === 100) {
              this.notificationService.show(`Congratulations! You completed ${updated.title}`, 'success');
            } else {
              this.notificationService.show(`Resumed ${updated.title} (Progress: ${nextProgress}%)`, 'info');
            }
            return EnrollmentActions.resumeCourseSuccess({ course: updated });
          }),
          catchError(error => of(EnrollmentActions.resumeCourseFailure({ error: error.message || 'Failed to resume' })))
        );
      })
    )
  );
}
