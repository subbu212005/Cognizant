import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnrollmentService } from '../../services/enrollment.service';

@Component({
  selector: 'app-course-summary-widget',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-summary-widget.html',
  styleUrl: './course-summary-widget.css'
})
export class CourseSummaryWidgetComponent {
  enrollmentService = inject(EnrollmentService);

  totalCredits = this.enrollmentService.totalCredits;
  completedCoursesCount = this.enrollmentService.completedCoursesCount;
  enrolledCoursesCount = this.enrollmentService.enrolledCoursesCount;
  overallProgress = this.enrollmentService.overallProgress;
}
