import { TestBed } from '@angular/core/testing';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { EnrollmentService } from './enrollment.service';
import { CourseService } from './course.service';
import { NotificationService } from './notification.service';
import { Course } from '../models/course';

describe('EnrollmentService', () => {
  let service: EnrollmentService;
  let courseService: CourseService;
  let notificationService: NotificationService;
  let httpMock: HttpTestingController;

  const mockCourses: Course[] = [
    {
      id: 'cs101',
      title: 'Advanced Web Development with Angular',
      instructor: 'Dr. Sarah Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Learn modern single-page application development.',
      progress: 45,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1517694712202-14dd9538aa97'
    },
    {
      id: 'cs102',
      title: 'Introduction to Artificial Intelligence',
      instructor: 'Prof. Michael Chen',
      credits: 4,
      category: 'Computer Science',
      description: 'Foundations of AI.',
      progress: 0,
      status: 'available',
      image: 'https://images.unsplash.com/photo-1677442136019-21780efad99a'
    },
    {
      id: 'math201',
      title: 'Linear Algebra & Numerical Methods',
      instructor: 'Dr. Emily Watson',
      credits: 3,
      category: 'Mathematics',
      description: 'Vector spaces, linear transformations.',
      progress: 100,
      status: 'completed',
      image: 'https://images.unsplash.com/photo-1635070041078-e363dbe005cb'
    },
    {
      id: 'dsn104',
      title: 'User Experience & Interface Design',
      instructor: 'Marcus Aurelius',
      credits: 3,
      category: 'Design',
      description: 'Principles of UX.',
      progress: 80,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1541462608143-67571c6738dd'
    },
    {
      id: 'cs203',
      title: 'Data Structures and Algorithms',
      instructor: 'Dr. Sarah Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Abstract data types.',
      progress: 10,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1526374965328-7f61d4dc18c5'
    }
  ];

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        EnrollmentService,
        CourseService,
        NotificationService,
        provideHttpClient(),
        provideHttpClientTesting()
      ]
    });

    httpMock = TestBed.inject(HttpTestingController);
    service = TestBed.inject(EnrollmentService);
    courseService = TestBed.inject(CourseService);
    notificationService = TestBed.inject(NotificationService);

    // Handle initial load in CourseService constructor
    const req = httpMock.expectOne('http://localhost:3000/courses');
    expect(req.request.method).toBe('GET');
    req.flush(mockCourses);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should calculate initial enrollment stats correctly', () => {
    // Enrolled: cs101 (45%), dsn104 (80%), cs203 (10%) = 3 courses
    // Completed: math201 (100%) = 1 course
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

    // Expect the PUT request from CourseService
    const req = httpMock.expectOne('http://localhost:3000/courses/cs102');
    expect(req.request.method).toBe('PUT');
    req.flush({ ...mockCourses[1], status: 'enrolled', progress: 0 });

    const course = courseService.getCourseById('cs102');
    expect(course?.status).toBe('enrolled');
    expect(course?.progress).toBe(0);
    expect(notifySpy).toHaveBeenCalledWith(expect.stringContaining('Successfully enrolled'), 'success');
  });

  it('should unenroll from an enrolled course', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // cs101 is initially enrolled
    service.unenrollFromCourse('cs101');

    // Expect the PUT request from CourseService
    const req = httpMock.expectOne('http://localhost:3000/courses/cs101');
    expect(req.request.method).toBe('PUT');
    req.flush({ ...mockCourses[0], status: 'available', progress: 0 });

    const course = courseService.getCourseById('cs101');
    expect(course?.status).toBe('available');
    expect(course?.progress).toBe(0);
    expect(notifySpy).toHaveBeenCalledWith(expect.stringContaining('Unenrolled from'), 'warning');
  });

  it('should resume course and increment progress', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // cs203 is initially enrolled at 10% progress
    service.resumeCourse('cs203');

    // Expect the PUT request from CourseService
    const req = httpMock.expectOne('http://localhost:3000/courses/cs203');
    expect(req.request.method).toBe('PUT');
    req.flush({ ...mockCourses[4], progress: 25, status: 'enrolled' });

    const course = courseService.getCourseById('cs203');
    expect(course?.progress).toBe(25);
    expect(course?.status).toBe('enrolled');
    expect(notifySpy).toHaveBeenCalledWith(expect.stringContaining('Resumed'), 'info');
  });

  it('should complete course when progress reaches 100%', () => {
    const notifySpy = vi.spyOn(notificationService, 'show');

    // dsn104 is enrolled at 80% progress. Resuming it twice will take it to 95% and then 100%.
    service.resumeCourse('dsn104'); // progress = 95%
    let req = httpMock.expectOne('http://localhost:3000/courses/dsn104');
    expect(req.request.method).toBe('PUT');
    req.flush({ ...mockCourses[3], progress: 95, status: 'enrolled' });

    service.resumeCourse('dsn104'); // progress = 100%
    req = httpMock.expectOne('http://localhost:3000/courses/dsn104');
    expect(req.request.method).toBe('PUT');
    req.flush({ ...mockCourses[3], progress: 100, status: 'completed' });

    const course = courseService.getCourseById('dsn104');
    expect(course?.progress).toBe(100);
    expect(course?.status).toBe('completed');
    expect(notifySpy).toHaveBeenLastCalledWith(expect.stringContaining('completed'), 'success');
  });
});
