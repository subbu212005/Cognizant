import { TestBed } from '@angular/core/testing';
import { CourseCardComponent } from './course-card';
import { Course } from '../../models/course';

describe('CourseCardComponent', () => {
  const mockCourse: Course = {
    id: 'test-course',
    title: 'Test Course Name',
    instructor: 'Jane Doe',
    credits: 3,
    category: 'Computer Science',
    description: 'Test Description',
    progress: 50,
    status: 'enrolled',
    image: 'test-img.jpg'
  };

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseCardComponent]
    }).compileComponents();
  });

  it('should create the course card component', () => {
    const fixture = TestBed.createComponent(CourseCardComponent);
    const component = fixture.componentInstance;
    component.course = mockCourse;
    fixture.detectChanges();
    expect(component).toBeTruthy();
  });

  it('should emit enroll event when onEnroll is called', () => {
    const fixture = TestBed.createComponent(CourseCardComponent);
    const component = fixture.componentInstance;
    component.course = { ...mockCourse, status: 'available' };
    fixture.detectChanges();

    let emittedId = '';
    component.enroll.subscribe((id: string) => emittedId = id);
    component.onEnroll();

    expect(emittedId).toBe('test-course');
  });

  it('should emit resume event when onResume is called', () => {
    const fixture = TestBed.createComponent(CourseCardComponent);
    const component = fixture.componentInstance;
    component.course = mockCourse;
    fixture.detectChanges();

    let emittedId = '';
    component.resume.subscribe((id: string) => emittedId = id);
    component.onResume();

    expect(emittedId).toBe('test-course');
  });
});
