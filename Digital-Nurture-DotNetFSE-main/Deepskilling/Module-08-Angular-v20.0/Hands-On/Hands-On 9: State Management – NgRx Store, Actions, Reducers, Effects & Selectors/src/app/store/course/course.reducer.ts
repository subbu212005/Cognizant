import { createReducer, on } from '@ngrx/store';
import { initialCourseState } from './course.state';
import { CourseActions } from './course.actions';
import { EnrollmentActions } from '../enrollment/enrollment.actions';

export const courseReducer = createReducer(
  initialCourseState,
  on(CourseActions.loadCourses, (state) => ({
    ...state,
    loading: true,
    error: null
  })),
  on(CourseActions.loadCoursesSuccess, (state, { courses }) => ({
    ...state,
    courses,
    loading: false,
    error: null
  })),
  on(CourseActions.loadCoursesFailure, (state, { error }) => ({
    ...state,
    loading: false,
    error
  })),
  on(CourseActions.addCourseSuccess, (state, { course }) => ({
    ...state,
    courses: [...state.courses, course]
  })),
  on(CourseActions.updateCourseSuccess, (state, { course }) => ({
    ...state,
    courses: state.courses.map(c => c.id === course.id ? course : c)
  })),
  on(CourseActions.deleteCourseSuccess, (state, { courseId }) => ({
    ...state,
    courses: state.courses.filter(c => c.id !== courseId)
  })),
  // Handle enrollment successes directly in the course state
  on(EnrollmentActions.enrollCourseSuccess, (state, { course }) => ({
    ...state,
    courses: state.courses.map(c => c.id === course.id ? course : c)
  })),
  on(EnrollmentActions.unenrollCourseSuccess, (state, { course }) => ({
    ...state,
    courses: state.courses.map(c => c.id === course.id ? course : c)
  })),
  on(EnrollmentActions.resumeCourseSuccess, (state, { course }) => ({
    ...state,
    courses: state.courses.map(c => c.id === course.id ? course : c)
  }))
);
