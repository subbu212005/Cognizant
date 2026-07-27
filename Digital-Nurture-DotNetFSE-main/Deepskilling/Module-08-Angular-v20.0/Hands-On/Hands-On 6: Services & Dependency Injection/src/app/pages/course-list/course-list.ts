import { Component, inject, signal, computed } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { CourseCardComponent } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule, CourseCardComponent],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseListComponent {
  courseService = inject(CourseService);
  enrollmentService = inject(EnrollmentService);
  courses = this.courseService.courses;

  // Filters State
  searchTerm = signal('');
  selectedCategory = signal('All');
  selectedStatus = signal('All');

  // Categories list for filter UI
  categories = ['All', 'Computer Science', 'Mathematics', 'Design', 'Business'];

  // Statuses list for filter UI
  statuses = ['All', 'Available', 'Enrolled', 'Completed'];

  // Filtered Course Catalog
  filteredCourses = computed(() => {
    const search = this.searchTerm().toLowerCase().trim();
    const cat = this.selectedCategory();
    const stat = this.selectedStatus().toLowerCase();

    return this.courses().filter(course => {
      const matchesSearch = course.title.toLowerCase().includes(search) || 
                            course.description.toLowerCase().includes(search) ||
                            course.instructor.toLowerCase().includes(search);
      const matchesCategory = cat === 'All' || course.category === cat;
      const matchesStatus = stat === 'all' || course.status === stat;

      return matchesSearch && matchesCategory && matchesStatus;
    });
  });

  onSearch(event: Event) {
    const value = (event.target as HTMLInputElement).value;
    this.searchTerm.set(value);
  }

  setCategory(category: string) {
    this.selectedCategory.set(category);
  }

  setStatus(status: string) {
    this.selectedStatus.set(status);
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

