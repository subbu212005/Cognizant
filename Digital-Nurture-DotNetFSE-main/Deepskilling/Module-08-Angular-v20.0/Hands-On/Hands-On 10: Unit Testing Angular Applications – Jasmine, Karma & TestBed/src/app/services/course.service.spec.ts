import { TestBed } from '@angular/core/testing';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { CourseService } from './course.service';
import { Course } from '../models/course';
import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';
import { courseReducer } from '../store/course/course.reducer';
import { CourseEffects } from '../store/course/course.effects';

describe('CourseService', () => {
  let service: CourseService;
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
    }
  ];

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        CourseService,
        provideHttpClient(),
        provideHttpClientTesting(),
        provideStore({ course: courseReducer }),
        provideEffects([CourseEffects])
      ]
    });

    httpMock = TestBed.inject(HttpTestingController);
    service = TestBed.inject(CourseService);

    // Handle initial load
    service.loadCourses();
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

  it('should initialize with courses list from API', () => {
    const courses = service.courses();
    expect(courses.length).toBe(2);
    expect(courses[0].id).toBe('cs101');
    expect(courses[1].status).toBe('available');
  });

  it('should add a new course', () => {
    const newCourse: Omit<Course, 'id' | 'progress' | 'image'> = {
      title: 'Software Engineering Essentials',
      instructor: 'Dr. John Doe',
      credits: 3,
      category: 'Computer Science',
      description: 'Introduction to software processes.',
      status: 'available'
    };

    service.addCourse(newCourse);

    const req = httpMock.expectOne('http://localhost:3000/courses');
    expect(req.request.method).toBe('POST');
    
    const flushedCourse: Course = {
      ...newCourse,
      id: 'course_12345',
      progress: 0,
      image: 'https://images.unsplash.com/photo-1516321318423-f06f85e504b3'
    };
    req.flush(flushedCourse);

    const courses = service.courses();
    expect(courses.length).toBe(3);
    const added = courses.find(c => c.title === 'Software Engineering Essentials');
    expect(added).toBeTruthy();
    expect(added?.id).toBe('course_12345');
  });

  it('should update course details', () => {
    service.updateCourse('cs102', { status: 'enrolled', progress: 15 });

    const req = httpMock.expectOne('http://localhost:3000/courses/cs102');
    expect(req.request.method).toBe('PUT');
    
    const updatedFlushed: Course = {
      ...mockCourses[1],
      status: 'enrolled',
      progress: 15
    };
    req.flush(updatedFlushed);

    const updated = service.getCourseById('cs102');
    expect(updated).toBeDefined();
    expect(updated?.status).toBe('enrolled');
    expect(updated?.progress).toBe(15);
  });

  it('should delete a course', () => {
    service.deleteCourse('cs101');

    const req = httpMock.expectOne('http://localhost:3000/courses/cs101');
    expect(req.request.method).toBe('DELETE');
    req.flush(null);

    const courses = service.courses();
    expect(courses.length).toBe(1);
    expect(courses[0].id).toBe('cs102');
  });
});
