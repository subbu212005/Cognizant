import { TestBed, ComponentFixture } from '@angular/core/testing';
import { provideRouter, ActivatedRoute, Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { CourseDetailComponent } from './course-detail';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { convertToParamMap } from '@angular/router';
import { Component } from '@angular/core';
import { provideHttpClient } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { Course } from '../../models/course';

@Component({
  template: ''
})
class DummyComponent {}

describe('CourseDetailComponent', () => {
  let component: CourseDetailComponent;
  let fixture: ComponentFixture<CourseDetailComponent>;
  let courseService: CourseService;
  let enrollmentService: EnrollmentService;
  let router: Router;
  let paramMap$: BehaviorSubject<any>;
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
    }
  ];

  beforeEach(async () => {
    paramMap$ = new BehaviorSubject(convertToParamMap({ id: 'cs101' }));

    await TestBed.configureTestingModule({
      imports: [CourseDetailComponent],
      providers: [
        provideRouter([
          { path: 'not-found', component: DummyComponent }
        ]),
        {
          provide: ActivatedRoute,
          useValue: {
            paramMap: paramMap$.asObservable()
          }
        },
        provideHttpClient(),
        provideHttpClientTesting()
      ]
    }).compileComponents();

    httpMock = TestBed.inject(HttpTestingController);
    fixture = TestBed.createComponent(CourseDetailComponent);
    component = fixture.componentInstance;
    courseService = TestBed.inject(CourseService);
    enrollmentService = TestBed.inject(EnrollmentService);
    router = TestBed.inject(Router);

    // Handle initial courses request in CourseService constructor
    const req = httpMock.expectOne('http://localhost:3000/courses');
    expect(req.request.method).toBe('GET');
    req.flush(mockCourses);

    fixture.detectChanges();
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should create the course detail component', () => {
    expect(component).toBeTruthy();
  });

  it('should load course details on init', () => {
    const course = component.course();
    expect(course).toBeTruthy();
    expect(course?.id).toBe('cs101');
    expect(course?.title).toBe('Advanced Web Development with Angular');
  });

  it('should redirect to not-found when course does not exist', () => {
    const navigateSpy = vi.spyOn(router, 'navigate').mockImplementation(() => Promise.resolve(true));
    paramMap$.next(convertToParamMap({ id: 'non-existing-id' }));
    fixture.detectChanges();

    expect(navigateSpy).toHaveBeenCalledWith(['/not-found'], { skipLocationChange: true });
  });

  it('should call enrollmentService when enroll is called', () => {
    const enrollSpy = vi.spyOn(enrollmentService, 'enrollInCourse');
    component.enroll();

    const req = httpMock.expectOne('http://localhost:3000/courses/cs101');
    expect(req.request.method).toBe('PUT');
    req.flush({ id: 'cs101', status: 'enrolled', progress: 0 });

    expect(enrollSpy).toHaveBeenCalledWith('cs101');
  });

  it('should call enrollmentService when resume is called', () => {
    const resumeSpy = vi.spyOn(enrollmentService, 'resumeCourse');
    component.resume();

    const req = httpMock.expectOne('http://localhost:3000/courses/cs101');
    expect(req.request.method).toBe('PUT');
    req.flush({ id: 'cs101', status: 'enrolled', progress: 60 });

    expect(resumeSpy).toHaveBeenCalledWith('cs101');
  });

  it('should call enrollmentService when unenroll is called', () => {
    const unenrollSpy = vi.spyOn(enrollmentService, 'unenrollFromCourse');
    component.unenroll();

    const req = httpMock.expectOne('http://localhost:3000/courses/cs101');
    expect(req.request.method).toBe('PUT');
    req.flush({ id: 'cs101', status: 'available', progress: 0 });

    expect(unenrollSpy).toHaveBeenCalledWith('cs101');
  });
});
