import { createActionGroup, props } from '@ngrx/store';
import { Course } from '../../models/course';

export const EnrollmentActions = createActionGroup({
  source: 'Enrollment',
  events: {
    'Enroll Course': props<{ courseId: string }>(),
    'Enroll Course Success': props<{ course: Course }>(),
    'Enroll Course Failure': props<{ error: string }>(),
    'Unenroll Course': props<{ courseId: string }>(),
    'Unenroll Course Success': props<{ course: Course }>(),
    'Unenroll Course Failure': props<{ error: string }>(),
    'Resume Course': props<{ courseId: string }>(),
    'Resume Course Success': props<{ course: Course }>(),
    'Resume Course Failure': props<{ error: string }>()
  }
});
