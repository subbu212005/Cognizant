import { TestBed, ComponentFixture } from '@angular/core/testing';
import { provideRouter, ActivatedRoute, Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { CourseDetailComponent } from './course-detail';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { convertToParamMap } from '@angular/router';
import { Component } from '@angular/core';

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
        }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(CourseDetailComponent);
    component = fixture.componentInstance;
    courseService = TestBed.inject(CourseService);
    enrollmentService = TestBed.inject(EnrollmentService);
    router = TestBed.inject(Router);
    fixture.detectChanges();
  });

  it('should create the course detail component', () => {
    expect(component).toBeTruthy();
  });

  it('should load course details on init', () => {
    fixture.detectChanges();
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
    expect(enrollSpy).toHaveBeenCalledWith('cs101');
  });

  it('should call enrollmentService when resume is called', () => {
    const resumeSpy = vi.spyOn(enrollmentService, 'resumeCourse');
    component.resume();
    expect(resumeSpy).toHaveBeenCalledWith('cs101');
  });

  it('should call enrollmentService when unenroll is called', () => {
    const unenrollSpy = vi.spyOn(enrollmentService, 'unenrollFromCourse');
    component.unenroll();
    expect(unenrollSpy).toHaveBeenCalledWith('cs101');
  });
});
