import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { CourseService } from '../../services/course.service';
import { NotificationService } from '../../services/notification.service';

@Component({
  selector: 'app-enrollment-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterLink],
  templateUrl: './enrollment-form.html',
  styleUrl: './enrollment-form.css'
})
export class EnrollmentFormComponent implements OnInit {
  private fb = inject(FormBuilder);
  private router = inject(Router);
  courseService = inject(CourseService);
  notificationService = inject(NotificationService);

  enrollmentForm!: FormGroup;
  showSuccessAlert = false;
  categories = ['Computer Science', 'Mathematics', 'Design', 'Business'];

  ngOnInit() {
    this.enrollmentForm = this.fb.group({
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
      this.courseService.addCourse(this.enrollmentForm.value);
      this.notificationService.show(`Course "${this.enrollmentForm.value.title}" added successfully`, 'success');
      this.showSuccessAlert = true;
      
      this.enrollmentForm.reset({
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

