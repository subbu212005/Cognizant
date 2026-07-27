import { createFeatureSelector, createSelector } from '@ngrx/store';
import { EnrollmentState } from './enrollment.state';
import { selectCourses } from '../course/course.selectors';

export const selectEnrollmentState = createFeatureSelector<EnrollmentState>('enrollment');

export const selectEnrolledCourseIds = createSelector(
  selectEnrollmentState,
  (state) => state.enrolledCourseIds
);

export const selectEnrollmentLoading = createSelector(
  selectEnrollmentState,
  (state) => state.loading
);

export const selectEnrollmentError = createSelector(
  selectEnrollmentState,
  (state) => state.error
);

// Calculate total credits for Enrolled and Completed courses
export const selectTotalCredits = createSelector(
  selectCourses,
  (courses) => courses
    .filter(c => c.status === 'enrolled' || c.status === 'completed')
    .reduce((sum, c) => sum + c.credits, 0)
);

// Calculate count of Completed courses
export const selectCompletedCoursesCount = createSelector(
  selectCourses,
  (courses) => courses.filter(c => c.status === 'completed').length
);

// Calculate count of Enrolled courses
export const selectEnrolledCoursesCount = createSelector(
  selectCourses,
  (courses) => courses.filter(c => c.status === 'enrolled').length
);

// Calculate overall study progress percentage
export const selectOverallProgress = createSelector(
  selectCourses,
  (courses) => {
    const activeCourses = courses.filter(c => c.status === 'enrolled' || c.status === 'completed');
    if (activeCourses.length === 0) return 0;
    const totalProgress = activeCourses.reduce((sum, c) => sum + c.progress, 0);
    return Math.round(totalProgress / activeCourses.length);
  }
);
