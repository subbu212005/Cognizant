import { TestBed } from '@angular/core/testing';
import { CourseListComponent } from './course-list';
import { provideRouter } from '@angular/router';
import { provideHttpClient } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { Course } from '../../models/course';

describe('CourseListComponent', () => {
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

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseListComponent],
      providers: [
        provideRouter([]),
        provideHttpClient(),
        provideHttpClientTesting()
      ]
    }).compileComponents();

    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  const createComponent = () => {
    const fixture = TestBed.createComponent(CourseListComponent);
    const req = httpMock.expectOne('http://localhost:3000/courses');
    expect(req.request.method).toBe('GET');
    req.flush(mockCourses);
    fixture.detectChanges();
    return fixture;
  };

  it('should create the course list page component', () => {
    const fixture = createComponent();
    const component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });

  it('should filter courses by search term', () => {
    const fixture = createComponent();
    const component = fixture.componentInstance;

    component.searchTerm.set('Angular');
    const filtered = component.filteredCourses();
    expect(filtered.length).toBeGreaterThan(0);
    expect(filtered.every(c => c.title.includes('Angular') || c.description.includes('Angular'))).toBe(true);
  });

  it('should call enrollmentService.unenrollFromCourse when unenroll is called', () => {
    const fixture = createComponent();
    const component = fixture.componentInstance;

    const unenrollSpy = vi.spyOn(component.enrollmentService, 'unenrollFromCourse');
    component.unenroll('cs101');

    const req = httpMock.expectOne('http://localhost:3000/courses/cs101');
    expect(req.request.method).toBe('PUT');
    req.flush({ id: 'cs101', status: 'available', progress: 0 });

    expect(unenrollSpy).toHaveBeenCalledWith('cs101');
  });

  it('should call courseService.deleteCourse when delete is called and confirmed', () => {
    const fixture = createComponent();
    const component = fixture.componentInstance;

    vi.spyOn(window, 'confirm').mockReturnValue(true);
    const deleteSpy = vi.spyOn(component.courseService, 'deleteCourse').mockImplementation(() => {});

    component.delete('cs101');

    expect(deleteSpy).toHaveBeenCalledWith('cs101');
  });
});
