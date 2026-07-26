import { Component, inject } from '@angular/core';
import { RouterLink } from '@angular/router';
import { PortalService } from '../../services/portal.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class HomeComponent {
  portalService = inject(PortalService);
  student = this.portalService.student;
  courses = this.portalService.courses;
  
  totalCredits = this.portalService.totalCredits;
  completedCoursesCount = this.portalService.completedCoursesCount;
  enrolledCoursesCount = this.portalService.enrolledCoursesCount;
  overallProgress = this.portalService.overallProgress;

  getEnrolledCourses() {
    return this.courses().filter(c => c.status === 'enrolled');
  }
}
