import { TestBed } from '@angular/core/testing';
import { CourseService } from './course.service';
import { Course } from '../models/course';

describe('CourseService', () => {
  let service: CourseService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CourseService]
    });
    service = TestBed.inject(CourseService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should initialize with default courses list', () => {
    const courses = service.courses();
    expect(courses.length).toBe(6);
    expect(courses[0].id).toBe('cs101');
    expect(courses[1].status).toBe('available');
  });

  it('should add a new course', () => {
    const newCourse: Omit<Course, 'id' | 'progress' | 'image'> = {
      title: 'Software Engineering Essentials',
      instructor: 'Dr. John Doe',
      credits: 3,
      category: 'Computer Science',
      description: 'Introduction to software processes, design patterns, testing, and Git workflows.',
      status: 'available'
    };

    service.addCourse(newCourse);
    const courses = service.courses();
    
    expect(courses.length).toBe(7);
    const added = courses.find(c => c.title === 'Software Engineering Essentials');
    expect(added).toBeTruthy();
    expect(added?.id).toBeDefined();
    expect(added?.progress).toBe(0);
  });

  it('should update course details', () => {
    service.updateCourse('cs102', { status: 'enrolled', progress: 15 });
    const updated = service.getCourseById('cs102');
    expect(updated).toBeDefined();
    expect(updated?.status).toBe('enrolled');
    expect(updated?.progress).toBe(15);
  });
});
