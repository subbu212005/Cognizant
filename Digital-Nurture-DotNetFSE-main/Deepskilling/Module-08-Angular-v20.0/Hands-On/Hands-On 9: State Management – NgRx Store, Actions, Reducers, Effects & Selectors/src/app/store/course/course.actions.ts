import { createActionGroup, emptyProps, props } from '@ngrx/store';
import { Course } from '../../models/course';

export const CourseActions = createActionGroup({
  source: 'Course API',
  events: {
    'Load Courses': emptyProps(),
    'Load Courses Success': props<{ courses: Course[] }>(),
    'Load Courses Failure': props<{ error: string }>(),
    'Add Course': props<{ course: Omit<Course, 'id' | 'progress' | 'image'> & { id?: string } }>(),
    'Add Course Success': props<{ course: Course }>(),
    'Add Course Failure': props<{ error: string }>(),
    'Update Course': props<{ courseId: string; updates: Partial<Course> }>(),
    'Update Course Success': props<{ course: Course }>(),
    'Update Course Failure': props<{ error: string }>(),
    'Delete Course': props<{ courseId: string }>(),
    'Delete Course Success': props<{ courseId: string }>(),
    'Delete Course Failure': props<{ error: string }>()
  }
});
