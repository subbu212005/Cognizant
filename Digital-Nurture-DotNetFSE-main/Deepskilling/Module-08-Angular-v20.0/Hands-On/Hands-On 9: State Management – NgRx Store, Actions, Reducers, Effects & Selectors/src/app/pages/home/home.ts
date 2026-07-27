import { Component, inject } from '@angular/core';
import { RouterLink } from '@angular/router';
import { PortalService } from '../../services/portal.service';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { AuthService } from '../../services/auth.service';
import { CourseSummaryWidgetComponent } from '../../components/course-summary-widget/course-summary-widget';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, RouterLink, CourseSummaryWidgetComponent],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class HomeComponent {
  portalService = inject(PortalService);
  courseService = inject(CourseService);
  enrollmentService = inject(EnrollmentService);
  authService = inject(AuthService);

  student = this.portalService.student;
  courses = this.courseService.courses;
  enrolledCoursesCount = this.enrollmentService.enrolledCoursesCount;
  isLoggedIn = this.authService.isLoggedIn;

  login() {
    this.authService.login();
  }

  getEnrolledCourses() {
    return this.courses().filter(c => c.status === 'enrolled');
  }
}
