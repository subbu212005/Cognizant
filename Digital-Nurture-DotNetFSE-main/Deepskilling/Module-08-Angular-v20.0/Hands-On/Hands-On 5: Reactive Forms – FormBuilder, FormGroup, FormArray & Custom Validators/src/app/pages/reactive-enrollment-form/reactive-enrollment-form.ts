import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { PortalService } from '../../services/portal.service';
import { courseCodeValidator } from '../../validators/course-code.validator';

@Component({
  selector: 'app-reactive-enrollment-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterLink],
  templateUrl: './reactive-enrollment-form.html',
  styleUrl: './reactive-enrollment-form.css'
})
export class ReactiveEnrollmentFormComponent implements OnInit {
  private fb = inject(FormBuilder);
  private router = inject(Router);
  portalService = inject(PortalService);

  enrollmentForm!: FormGroup;
  showSuccessAlert = false;
  categories = ['Computer Science', 'Mathematics', 'Design', 'Business'];

  ngOnInit() {
    this.enrollmentForm = this.fb.group({
      code: ['', [Validators.required, courseCodeValidator()]],
      title: ['', [Validators.required, Validators.minLength(3)]],
      instructor: ['', [Validators.required, Validators.minLength(3)]],
      credits: [3, [Validators.required, Validators.min(1), Validators.max(5)]],
      category: ['Computer Science', [Validators.required]],
      description: ['', [Validators.required, Validators.minLength(10)]],
      status: ['enrolled', [Validators.required]]
    });
  }

  onSubmit() {
    if (this.enrollmentForm.valid) {
      const formData = this.enrollmentForm.value;
      this.portalService.addCourse({
        id: formData.code.toLowerCase().trim(),
        title: formData.title,
        instructor: formData.instructor,
        credits: formData.credits,
        category: formData.category,
        description: formData.description,
        status: formData.status
      });
      
      this.showSuccessAlert = true;

      this.enrollmentForm.reset({
        code: '',
        title: '',
        instructor: '',
        credits: 3,
        category: 'Computer Science',
        description: '',
        status: 'enrolled'
      });

      setTimeout(() => {
        this.showSuccessAlert = false;
        this.router.navigate(['/courses']);
      }, 2000);
    }
  }
}
