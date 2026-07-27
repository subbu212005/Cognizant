import { createReducer, on } from '@ngrx/store';
import { initialEnrollmentState } from './enrollment.state';
import { EnrollmentActions } from './enrollment.actions';
import { CourseActions } from '../course/course.actions';

export const enrollmentReducer = createReducer(
  initialEnrollmentState,
  // When courses are initially loaded, initialize enrolledCourseIds from the course list
  on(CourseActions.loadCoursesSuccess, (state, { courses }) => ({
    ...state,
    enrolledCourseIds: courses.filter(c => c.status === 'enrolled').map(c => c.id)
  })),
  on(EnrollmentActions.enrollCourse, (state) => ({
    ...state,
    loading: true,
    error: null
  })),
  on(EnrollmentActions.enrollCourseSuccess, (state, { course }) => ({
    ...state,
    loading: false,
    enrolledCourseIds: state.enrolledCourseIds.includes(course.id)
      ? state.enrolledCourseIds
      : [...state.enrolledCourseIds, course.id]
  })),
  on(EnrollmentActions.enrollCourseFailure, (state, { error }) => ({
    ...state,
    loading: false,
    error
  })),
  on(EnrollmentActions.unenrollCourse, (state) => ({
    ...state,
    loading: true,
    error: null
  })),
  on(EnrollmentActions.unenrollCourseSuccess, (state, { course }) => ({
    ...state,
    loading: false,
    enrolledCourseIds: state.enrolledCourseIds.filter(id => id !== course.id)
  })),
  on(EnrollmentActions.unenrollCourseFailure, (state, { error }) => ({
    ...state,
    loading: false,
    error
  })),
  on(EnrollmentActions.resumeCourse, (state) => ({
    ...state,
    loading: true,
    error: null
  })),
  on(EnrollmentActions.resumeCourseSuccess, (state) => ({
    ...state,
    loading: false
  })),
  on(EnrollmentActions.resumeCourseFailure, (state, { error }) => ({
    ...state,
    loading: false,
    error
  }))
);
