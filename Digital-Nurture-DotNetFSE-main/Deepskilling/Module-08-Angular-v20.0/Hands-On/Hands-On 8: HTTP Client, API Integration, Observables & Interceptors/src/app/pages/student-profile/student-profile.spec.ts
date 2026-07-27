import { TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { StudentProfileComponent } from './student-profile';
import { provideRouter } from '@angular/router';
import { provideHttpClient } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { Course } from '../../models/course';

describe('StudentProfileComponent', () => {
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
    },
    {
      id: 'dsn104',
      title: 'User Experience & Interface Design',
      instructor: 'Marcus Aurelius',
      credits: 3,
      category: 'Design',
      description: 'Principles of UX.',
      progress: 80,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1541462608143-67571c6738dd'
    },
    {
      id: 'cs203',
      title: 'Data Structures and Algorithms',
      instructor: 'Dr. Sarah Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Abstract data types.',
      progress: 10,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1526374965328-7f61d4dc18c5'
    }
  ];

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StudentProfileComponent, ReactiveFormsModule],
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
    const fixture = TestBed.createComponent(StudentProfileComponent);
    const req = httpMock.expectOne('http://localhost:3000/courses');
    expect(req.request.method).toBe('GET');
    req.flush(mockCourses);
    fixture.detectChanges();
    return fixture;
  };

  it('should create the student profile component', () => {
    const fixture = createComponent();
    const component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });

  it('should validate form fields', () => {
    const fixture = createComponent();
    const component = fixture.componentInstance;

    const form = component.profileForm;
    expect(form.valid).toBe(true); // initially valid with service defaults

    form.patchValue({ name: '' });
    expect(form.get('name')?.invalid).toBe(true);

    form.patchValue({ name: 'Al' }); // too short
    expect(form.get('name')?.invalid).toBe(true);

    form.patchValue({ email: 'invalid-email' });
    expect(form.get('email')?.invalid).toBe(true);

    form.patchValue({ studentId: '12345' }); // doesn't match pattern
    expect(form.get('studentId')?.invalid).toBe(true);
  });

  it('should display enrolled courses', () => {
    const fixture = createComponent();

    const compiled = fixture.nativeElement as HTMLElement;
    // Default data has 3 enrolled courses (cs101, dsn104, cs203)
    const courseCards = compiled.querySelectorAll('app-course-card');
    expect(courseCards.length).toBe(3);
  });
});
