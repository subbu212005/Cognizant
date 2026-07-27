import { TestBed } from '@angular/core/testing';
import { CourseListComponent } from './course-list';
import { provideRouter } from '@angular/router';

describe('CourseListComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseListComponent],
      providers: [provideRouter([])]
    }).compileComponents();
  });

  it('should create the course list page component', () => {
    const fixture = TestBed.createComponent(CourseListComponent);
    const component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });

  it('should filter courses by search term', () => {
    const fixture = TestBed.createComponent(CourseListComponent);
    const component = fixture.componentInstance;
    fixture.detectChanges();

    component.searchTerm.set('Angular');
    const filtered = component.filteredCourses();
    expect(filtered.length).toBeGreaterThan(0);
    expect(filtered.every(c => c.title.includes('Angular') || c.description.includes('Angular'))).toBe(true);
  });

  it('should call enrollmentService.unenrollFromCourse when unenroll is called', () => {
    const fixture = TestBed.createComponent(CourseListComponent);
    const component = fixture.componentInstance;
    fixture.detectChanges();

    const unenrollSpy = vi.spyOn(component.enrollmentService, 'unenrollFromCourse');
    component.unenroll('cs101');
    expect(unenrollSpy).toHaveBeenCalledWith('cs101');
  });
});
