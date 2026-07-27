import { TestBed, ComponentFixture } from '@angular/core/testing';
import { CourseSummaryWidgetComponent } from './course-summary-widget';
import { EnrollmentService } from '../../services/enrollment.service';
import { CourseService } from '../../services/course.service';
import { NotificationService } from '../../services/notification.service';
import { provideHttpClient } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';
import { courseReducer } from '../../store/course/course.reducer';
import { enrollmentReducer } from '../../store/enrollment/enrollment.reducer';
import { CourseEffects } from '../../store/course/course.effects';

describe('CourseSummaryWidgetComponent', () => {
  let component: CourseSummaryWidgetComponent;
  let fixture: ComponentFixture<CourseSummaryWidgetComponent>;
  let enrollmentService: EnrollmentService;
  let httpMock: HttpTestingController;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseSummaryWidgetComponent],
      providers: [
        EnrollmentService,
        CourseService,
        NotificationService,
        provideHttpClient(),
        provideHttpClientTesting(),
        provideStore({
          course: courseReducer,
          enrollment: enrollmentReducer
        }),
        provideEffects([CourseEffects])
      ]
    }).compileComponents();

    httpMock = TestBed.inject(HttpTestingController);
    fixture = TestBed.createComponent(CourseSummaryWidgetComponent);
    component = fixture.componentInstance;
    enrollmentService = TestBed.inject(EnrollmentService);

    // Handle initial courses request explicitly
    const courseService = TestBed.inject(CourseService);
    courseService.loadCourses();
    const req = httpMock.expectOne('http://localhost:3000/courses');
    expect(req.request.method).toBe('GET');
    req.flush([]);

    fixture.detectChanges();
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should display correct statistics from EnrollmentService', () => {
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    
    // Find the stats values. First should be Enrolled/Active courses count, second is Credits, third is progress.
    const values = compiled.querySelectorAll('.stats-value');
    expect(values.length).toBe(3);
    
    expect(values[0].textContent?.trim()).toBe(enrollmentService.enrolledCoursesCount().toString());
    expect(values[1].textContent?.trim()).toBe(enrollmentService.totalCredits().toString());
    expect(values[2].textContent?.trim()).toBe(enrollmentService.overallProgress().toString() + '%');
  });
});
