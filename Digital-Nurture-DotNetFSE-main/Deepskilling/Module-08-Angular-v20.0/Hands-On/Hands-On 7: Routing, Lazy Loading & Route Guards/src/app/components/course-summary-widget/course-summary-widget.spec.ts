import { TestBed, ComponentFixture } from '@angular/core/testing';
import { CourseSummaryWidgetComponent } from './course-summary-widget';
import { EnrollmentService } from '../../services/enrollment.service';
import { CourseService } from '../../services/course.service';
import { NotificationService } from '../../services/notification.service';

describe('CourseSummaryWidgetComponent', () => {
  let component: CourseSummaryWidgetComponent;
  let fixture: ComponentFixture<CourseSummaryWidgetComponent>;
  let enrollmentService: EnrollmentService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseSummaryWidgetComponent],
      providers: [EnrollmentService, CourseService, NotificationService]
    }).compileComponents();

    fixture = TestBed.createComponent(CourseSummaryWidgetComponent);
    component = fixture.componentInstance;
    enrollmentService = TestBed.inject(EnrollmentService);
    fixture.detectChanges();
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
