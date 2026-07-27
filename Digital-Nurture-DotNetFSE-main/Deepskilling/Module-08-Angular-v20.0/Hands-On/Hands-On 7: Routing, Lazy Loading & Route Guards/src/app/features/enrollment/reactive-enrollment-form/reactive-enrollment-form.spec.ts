import { TestBed, ComponentFixture } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { provideRouter, Router } from '@angular/router';
import { ReactiveEnrollmentFormComponent } from './reactive-enrollment-form';
import { CourseService } from '../../../services/course.service';

describe('ReactiveEnrollmentFormComponent', () => {
  let component: ReactiveEnrollmentFormComponent;
  let fixture: ComponentFixture<ReactiveEnrollmentFormComponent>;
  let courseService: CourseService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReactiveEnrollmentFormComponent, ReactiveFormsModule],
      providers: [provideRouter([])]
    }).compileComponents();

    fixture = TestBed.createComponent(ReactiveEnrollmentFormComponent);
    component = fixture.componentInstance;
    courseService = TestBed.inject(CourseService);
    fixture.detectChanges();
  });


  it('should create the reactive enrollment form component', () => {
    expect(component).toBeTruthy();
  });

  it('should initialize form with default values', () => {
    const form = component.enrollmentForm;
    expect(form).toBeTruthy();
    expect(form.get('code')?.value).toBe('');
    expect(form.get('title')?.value).toBe('');
    expect(form.get('instructor')?.value).toBe('');
    expect(form.get('credits')?.value).toBe(3);
    expect(form.get('category')?.value).toBe('Computer Science');
    expect(form.get('status')?.value).toBe('enrolled');
  });

  it('should validate form fields including custom course code validator', () => {
    const form = component.enrollmentForm;
    expect(form.valid).toBe(false);

    const code = form.get('code');
    code?.setValue('');
    expect(code?.invalid).toBe(true);
    code?.setValue('CS');
    expect(code?.invalid).toBe(true);
    code?.setValue('101');
    expect(code?.invalid).toBe(true);
    code?.setValue('CS101');
    expect(code?.valid).toBe(true);
    code?.setValue('MATH201');
    expect(code?.valid).toBe(true);

    const title = form.get('title');
    title?.setValue('A');
    expect(title?.invalid).toBe(true);
    title?.setValue('Valid Title');
    expect(title?.valid).toBe(true);

    const instructor = form.get('instructor');
    instructor?.setValue('Dr. Jenkins');
    expect(instructor?.valid).toBe(true);

    const credits = form.get('credits');
    credits?.setValue(4);
    expect(credits?.valid).toBe(true);

    const description = form.get('description');
    description?.setValue('This is a longer valid description of the course.');
    expect(description?.valid).toBe(true);

    expect(form.valid).toBe(true);
  });

  it('should call addCourse and show success alert on valid submit', async () => {
    let timeoutCallback: Function | null = null;
    const originalSetTimeout = window.setTimeout;
    const setTimeoutSpy = vi.spyOn(window, 'setTimeout').mockImplementation((cb: any, delay?: number, ...args: any[]) => {
      if (delay === 2000) {
        timeoutCallback = cb;
        return 123 as any;
      }
      return originalSetTimeout(cb, delay, ...args);
    });

    const addCourseSpy = vi.spyOn(courseService, 'addCourse');
    const router = TestBed.inject(Router);
    const navigateSpy = vi.spyOn(router, 'navigate').mockImplementation(() => Promise.resolve(true));
    
    component.enrollmentForm.patchValue({
      code: 'CS101',
      title: 'Advanced Angular',
      instructor: 'Dr. Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Comprehensive course on Angular 19 internals.',
      status: 'enrolled'
    });
    
    fixture.detectChanges();
    expect(component.enrollmentForm.valid).toBe(true);

    component.onSubmit();
    fixture.detectChanges();
    
    expect(addCourseSpy).toHaveBeenCalledWith({
      id: 'cs101',
      title: 'Advanced Angular',
      instructor: 'Dr. Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Comprehensive course on Angular 19 internals.',
      status: 'enrolled'
    });

    expect(component.showSuccessAlert).toBe(true);
    expect(setTimeoutSpy).toHaveBeenCalled();
    expect(timeoutCallback).toBeTruthy();
    
    fixture.ngZone?.run(() => {
      if (timeoutCallback) {
        timeoutCallback();
      }
    });
    
    await fixture.whenStable();
    
    expect(component.showSuccessAlert).toBe(false);
    expect(navigateSpy).toHaveBeenCalledWith(['/courses']);
  });
});
