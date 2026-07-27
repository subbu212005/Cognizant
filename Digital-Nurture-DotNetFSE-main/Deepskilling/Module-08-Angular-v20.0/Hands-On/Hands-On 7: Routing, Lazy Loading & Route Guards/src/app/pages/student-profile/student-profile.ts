import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { PortalService } from '../../services/portal.service';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { CourseCardComponent } from '../../components/course-card/course-card';

@Component({
  selector: 'app-student-profile',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, CourseCardComponent],
  templateUrl: './student-profile.html',
  styleUrl: './student-profile.css'
})
export class StudentProfileComponent implements OnInit {
  private fb = inject(FormBuilder);
  portalService = inject(PortalService);
  courseService = inject(CourseService);
  enrollmentService = inject(EnrollmentService);

  student = this.portalService.student;
  courses = this.courseService.courses;

  profileForm!: FormGroup;
  showSuccessAlert = false;

  ngOnInit() {
    const current = this.student();
    this.profileForm = this.fb.group({
      name: [current.name, [Validators.required, Validators.minLength(3)]],
      email: [current.email, [Validators.required, Validators.email]],
      studentId: [current.studentId, [Validators.required, Validators.pattern(/^U\d{8}$/)]], // Matches U followed by 8 digits
      major: [current.major, [Validators.required]]
    });
  }

  saveProfile() {
    if (this.profileForm.valid) {
      this.portalService.updateProfile(this.profileForm.value);
      this.showSuccessAlert = true;
      setTimeout(() => {
        this.showSuccessAlert = false;
      }, 4000);
    }
  }

  getEnrolledCourses() {
    return this.courses().filter(c => c.status === 'enrolled');
  }

  enroll(courseId: string) {
    this.enrollmentService.enrollInCourse(courseId);
  }

  resume(courseId: string) {
    this.enrollmentService.resumeCourse(courseId);
  }

  unenroll(courseId: string) {
    this.enrollmentService.unenrollFromCourse(courseId);
  }
}

