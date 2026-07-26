import { TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { StudentProfileComponent } from './student-profile';

describe('StudentProfileComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StudentProfileComponent, ReactiveFormsModule]
    }).compileComponents();
  });

  it('should create the student profile component', () => {
    const fixture = TestBed.createComponent(StudentProfileComponent);
    const component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });

  it('should validate form fields', () => {
    const fixture = TestBed.createComponent(StudentProfileComponent);
    const component = fixture.componentInstance;
    fixture.detectChanges();

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
});
