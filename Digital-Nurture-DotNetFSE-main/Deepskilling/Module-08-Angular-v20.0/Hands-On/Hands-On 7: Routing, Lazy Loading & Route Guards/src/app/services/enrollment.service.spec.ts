import { TestBed } from '@angular/core/testing';
import { EnrollmentService } from './enrollment.service';
import { CourseService } from './course.service';
import { NotificationService } from './notification.service';

describe('EnrollmentService', () => {
  let service: EnrollmentService;
  let courseService: CourseService;
  let notificationService: NotificationService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EnrollmentService, CourseService, NotificationService]
    });
    service = TestBed.inject(EnrollmentService);
    courseService = TestBed.inject(CourseService);
    notificationService = TestBed.inject(NotificationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should calculate initial enrollment stats correctly', () => {
    // Default enrolled: cs101 (45%), dsn104 (80%), cs203 (10%) = 3 courses
    // Default completed: math201 (100%) = 1 course
    // Registered credits: cs101 (4) + dsn104 (3) + cs203 (4) + math201 (3) = 14 credits
    // Overall progress: (45 + 80 + 10 + 100) / 4 = 235 / 4 = 59%
    expect(service.enrolledCoursesCount()).toBe(3);
    expect(service.completedCoursesCount()).toBe(1);
    expect(service.totalCredits()).toBe(14);
    expect(service.overallProgress()).toBe(59);
  });

  it('should enroll in an available course', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // cs102 is initially available
    service.enrollInCourse('cs102');

    const course = courseService.getCourseById('cs102');
    expect(course?.status).toBe('enrolled');
    expect(course?.progress).toBe(0);
    expect(notifySpy).toHaveBeenCalledWith(expect.stringContaining('Successfully enrolled'), 'success');
  });

  it('should unenroll from an enrolled course', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // cs101 is initially enrolled
    service.unenrollFromCourse('cs101');

    const course = courseService.getCourseById('cs101');
    expect(course?.status).toBe('available');
    expect(course?.progress).toBe(0);
    expect(notifySpy).toHaveBeenCalledWith(expect.stringContaining('Unenrolled from'), 'warning');
  });

  it('should resume course and increment progress', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // cs203 is initially enrolled at 10% progress
    service.resumeCourse('cs203');

    const course = courseService.getCourseById('cs203');
    expect(course?.progress).toBe(25);
    expect(course?.status).toBe('enrolled');
    expect(notifySpy).toHaveBeenCalledWith(expect.stringContaining('Resumed'), 'info');
  });

  it('should complete course when progress reaches 100%', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // dsn104 is enrolled at 80% progress. Resuming it twice will take it to 95% and then 100%.
    service.resumeCourse('dsn104'); // progress = 95%
    service.resumeCourse('dsn104'); // progress = 100%

    const course = courseService.getCourseById('dsn104');
    expect(course?.progress).toBe(100);
    expect(course?.status).toBe('completed');
    expect(notifySpy).toHaveBeenLastCalledWith(expect.stringContaining('completed'), 'success');
  });
});
