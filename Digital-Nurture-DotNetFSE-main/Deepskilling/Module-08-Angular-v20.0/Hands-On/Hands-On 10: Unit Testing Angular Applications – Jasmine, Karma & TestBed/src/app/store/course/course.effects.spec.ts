import { TestBed } from '@angular/core/testing';
import { CourseEffects } from './course.effects';
import { Actions } from '@ngrx/effects';
import { CourseService } from '../../services/course.service';
import { NotificationService } from '../../services/notification.service';
import { CourseActions } from './course.actions';
import { EnrollmentActions } from '../enrollment/enrollment.actions';
import { Subject, of, throwError } from 'rxjs';
import { Course } from '../../models/course';

describe('CourseEffects', () => {
  let effects: CourseEffects;
  let actions$: Subject<any>;
  let courseServiceMock: any;
  let notificationServiceMock: any;

  const mockCourse: Course = {
    id: 'cs101',
    title: 'Advanced Web Development with Angular',
    instructor: 'Dr. Sarah Jenkins',
    credits: 4,
    category: 'Computer Science',
    description: 'Learn modern SPAs.',
    progress: 45,
    status: 'enrolled',
    image: 'img.jpg'
  };

  beforeEach(() => {
    actions$ = new Subject<any>();
    courseServiceMock = {
      loadCoursesApi: vi.fn(),
      addCourseApi: vi.fn(),
      updateCourseApi: vi.fn(),
      deleteCourseApi: vi.fn(),
      getCourseById: vi.fn()
    };
    notificationServiceMock = {
      show: vi.fn()
    };

    TestBed.configureTestingModule({
      providers: [
        CourseEffects,
        { provide: Actions, useValue: actions$ },
        { provide: CourseService, useValue: courseServiceMock },
        { provide: NotificationService, useValue: notificationServiceMock }
      ]
    });

    effects = TestBed.inject(CourseEffects);
  });

  // 1. loadCourses$ tests
  describe('loadCourses$', () => {
    it('should dispatch loadCoursesSuccess on success', () => {
      const courses = [mockCourse];
      courseServiceMock.loadCoursesApi.mockReturnValue(of(courses));

      let resultAction: any;
      effects.loadCourses$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.loadCourses());

      expect(courseServiceMock.loadCoursesApi).toHaveBeenCalled();
      expect(resultAction).toEqual(CourseActions.loadCoursesSuccess({ courses }));
    });

    it('should dispatch loadCoursesFailure on failure', () => {
      const errorMsg = 'Failed to fetch';
      courseServiceMock.loadCoursesApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.loadCourses$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.loadCourses());

      expect(resultAction).toEqual(CourseActions.loadCoursesFailure({ error: errorMsg }));
    });
  });

  // 2. addCourse$ tests
  describe('addCourse$', () => {
    it('should dispatch addCourseSuccess and notify on success', () => {
      courseServiceMock.addCourseApi.mockReturnValue(of(mockCourse));

      let resultAction: any;
      effects.addCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.addCourse({ course: mockCourse }));

      expect(courseServiceMock.addCourseApi).toHaveBeenCalledWith(mockCourse);
      expect(notificationServiceMock.show).toHaveBeenCalledWith(
        `Course "${mockCourse.title}" added successfully`,
        'success'
      );
      expect(resultAction).toEqual(CourseActions.addCourseSuccess({ course: mockCourse }));
    });

    it('should dispatch addCourseFailure on failure', () => {
      const errorMsg = 'Error adding course';
      courseServiceMock.addCourseApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.addCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.addCourse({ course: mockCourse }));

      expect(resultAction).toEqual(CourseActions.addCourseFailure({ error: errorMsg }));
    });
  });

  // 3. updateCourse$ tests
  describe('updateCourse$', () => {
    it('should dispatch updateCourseSuccess on success', () => {
      const updates = { progress: 60 };
      const updatedCourse: Course = { ...mockCourse, ...updates };
      courseServiceMock.updateCourseApi.mockReturnValue(of(updatedCourse));

      let resultAction: any;
      effects.updateCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.updateCourse({ courseId: 'cs101', updates }));

      expect(courseServiceMock.updateCourseApi).toHaveBeenCalledWith('cs101', updates);
      expect(resultAction).toEqual(CourseActions.updateCourseSuccess({ course: updatedCourse }));
    });

    it('should dispatch updateCourseFailure on failure', () => {
      const errorMsg = 'Error updating course';
      courseServiceMock.updateCourseApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.updateCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.updateCourse({ courseId: 'cs101', updates: {} }));

      expect(resultAction).toEqual(CourseActions.updateCourseFailure({ error: errorMsg }));
    });
  });

  // 4. deleteCourse$ tests
  describe('deleteCourse$', () => {
    it('should dispatch deleteCourseSuccess and notify on success', () => {
      courseServiceMock.deleteCourseApi.mockReturnValue(of(undefined));

      let resultAction: any;
      effects.deleteCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.deleteCourse({ courseId: 'cs101' }));

      expect(courseServiceMock.deleteCourseApi).toHaveBeenCalledWith('cs101');
      expect(notificationServiceMock.show).toHaveBeenCalledWith(
        'Course deleted from catalog',
        'warning'
      );
      expect(resultAction).toEqual(CourseActions.deleteCourseSuccess({ courseId: 'cs101' }));
    });

    it('should dispatch deleteCourseFailure on failure', () => {
      const errorMsg = 'Error deleting course';
      courseServiceMock.deleteCourseApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.deleteCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(CourseActions.deleteCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(CourseActions.deleteCourseFailure({ error: errorMsg }));
    });
  });

  // 5. enrollCourse$ tests
  describe('enrollCourse$', () => {
    it('should dispatch enrollCourseSuccess and notify on success', () => {
      courseServiceMock.getCourseById.mockReturnValue(mockCourse);
      const updatedCourse: Course = { ...mockCourse, status: 'enrolled', progress: 0 };
      courseServiceMock.updateCourseApi.mockReturnValue(of(updatedCourse));

      let resultAction: any;
      effects.enrollCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.enrollCourse({ courseId: 'cs101' }));

      expect(courseServiceMock.getCourseById).toHaveBeenCalledWith('cs101');
      expect(courseServiceMock.updateCourseApi).toHaveBeenCalledWith('cs101', { status: 'enrolled', progress: 0 });
      expect(notificationServiceMock.show).toHaveBeenCalledWith(
        `Successfully enrolled in ${updatedCourse.title}`,
        'success'
      );
      expect(resultAction).toEqual(EnrollmentActions.enrollCourseSuccess({ course: updatedCourse }));
    });

    it('should dispatch enrollCourseFailure if course not found', () => {
      courseServiceMock.getCourseById.mockReturnValue(undefined);

      let resultAction: any;
      effects.enrollCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.enrollCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(EnrollmentActions.enrollCourseFailure({ error: 'Course not found' }));
      expect(courseServiceMock.updateCourseApi).not.toHaveBeenCalled();
    });

    it('should dispatch enrollCourseFailure on API failure', () => {
      courseServiceMock.getCourseById.mockReturnValue(mockCourse);
      const errorMsg = 'Failed to enroll';
      courseServiceMock.updateCourseApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.enrollCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.enrollCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(EnrollmentActions.enrollCourseFailure({ error: errorMsg }));
    });
  });

  // 6. unenrollCourse$ tests
  describe('unenrollCourse$', () => {
    it('should dispatch unenrollCourseSuccess and notify on success', () => {
      courseServiceMock.getCourseById.mockReturnValue(mockCourse);
      const updatedCourse: Course = { ...mockCourse, status: 'available', progress: 0 };
      courseServiceMock.updateCourseApi.mockReturnValue(of(updatedCourse));

      let resultAction: any;
      effects.unenrollCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.unenrollCourse({ courseId: 'cs101' }));

      expect(courseServiceMock.getCourseById).toHaveBeenCalledWith('cs101');
      expect(courseServiceMock.updateCourseApi).toHaveBeenCalledWith('cs101', { status: 'available', progress: 0 });
      expect(notificationServiceMock.show).toHaveBeenCalledWith(
        `Unenrolled from ${updatedCourse.title}`,
        'warning'
      );
      expect(resultAction).toEqual(EnrollmentActions.unenrollCourseSuccess({ course: updatedCourse }));
    });

    it('should dispatch unenrollCourseFailure if course not found', () => {
      courseServiceMock.getCourseById.mockReturnValue(undefined);

      let resultAction: any;
      effects.unenrollCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.unenrollCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(EnrollmentActions.unenrollCourseFailure({ error: 'Course not found' }));
    });

    it('should dispatch unenrollCourseFailure on API failure', () => {
      courseServiceMock.getCourseById.mockReturnValue(mockCourse);
      const errorMsg = 'Failed to unenroll';
      courseServiceMock.updateCourseApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.unenrollCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.unenrollCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(EnrollmentActions.unenrollCourseFailure({ error: errorMsg }));
    });
  });

  // 7. resumeCourse$ tests
  describe('resumeCourse$', () => {
    it('should dispatch resumeCourseSuccess and notify info on partial progress', () => {
      const courseWithPartial: Course = { ...mockCourse, progress: 50, status: 'enrolled' };
      courseServiceMock.getCourseById.mockReturnValue(courseWithPartial);

      // nextProgress = min(50 + 15, 100) = 65. status = 'enrolled'
      const updatedCourse: Course = { ...courseWithPartial, progress: 65, status: 'enrolled' };
      courseServiceMock.updateCourseApi.mockReturnValue(of(updatedCourse));

      let resultAction: any;
      effects.resumeCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.resumeCourse({ courseId: 'cs101' }));

      expect(courseServiceMock.getCourseById).toHaveBeenCalledWith('cs101');
      expect(courseServiceMock.updateCourseApi).toHaveBeenCalledWith('cs101', { progress: 65, status: 'enrolled' });
      expect(notificationServiceMock.show).toHaveBeenCalledWith(
        `Resumed ${updatedCourse.title} (Progress: 65%)`,
        'info'
      );
      expect(resultAction).toEqual(EnrollmentActions.resumeCourseSuccess({ course: updatedCourse }));
    });

    it('should dispatch resumeCourseSuccess and notify success on 100% completion', () => {
      const courseNearComplete: Course = { ...mockCourse, progress: 90, status: 'enrolled' };
      courseServiceMock.getCourseById.mockReturnValue(courseNearComplete);

      // nextProgress = min(90 + 15, 100) = 100. status = 'completed'
      const updatedCourse: Course = { ...courseNearComplete, progress: 100, status: 'completed' };
      courseServiceMock.updateCourseApi.mockReturnValue(of(updatedCourse));

      let resultAction: any;
      effects.resumeCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.resumeCourse({ courseId: 'cs101' }));

      expect(courseServiceMock.updateCourseApi).toHaveBeenCalledWith('cs101', { progress: 100, status: 'completed' });
      expect(notificationServiceMock.show).toHaveBeenCalledWith(
        `Congratulations! You completed ${updatedCourse.title}`,
        'success'
      );
      expect(resultAction).toEqual(EnrollmentActions.resumeCourseSuccess({ course: updatedCourse }));
    });

    it('should dispatch resumeCourseFailure if course not found', () => {
      courseServiceMock.getCourseById.mockReturnValue(undefined);

      let resultAction: any;
      effects.resumeCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.resumeCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(EnrollmentActions.resumeCourseFailure({ error: 'Course not found' }));
    });

    it('should dispatch resumeCourseFailure on API failure', () => {
      courseServiceMock.getCourseById.mockReturnValue(mockCourse);
      const errorMsg = 'Failed to resume';
      courseServiceMock.updateCourseApi.mockReturnValue(throwError(() => new Error(errorMsg)));

      let resultAction: any;
      effects.resumeCourse$.subscribe(action => {
        resultAction = action;
      });

      actions$.next(EnrollmentActions.resumeCourse({ courseId: 'cs101' }));

      expect(resultAction).toEqual(EnrollmentActions.resumeCourseFailure({ error: errorMsg }));
    });
  });
});
