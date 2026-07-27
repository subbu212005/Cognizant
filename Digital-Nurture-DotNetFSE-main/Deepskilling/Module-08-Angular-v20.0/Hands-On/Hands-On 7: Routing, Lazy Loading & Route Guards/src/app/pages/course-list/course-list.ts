import { Component, inject, signal, computed, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { CourseCardComponent } from '../../components/course-card/course-card';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule, CourseCardComponent],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseListComponent implements OnInit, OnDestroy {
  courseService = inject(CourseService);
  enrollmentService = inject(EnrollmentService);
  private route = inject(ActivatedRoute);
  private router = inject(Router);

  courses = this.courseService.courses;
  private querySub!: Subscription;

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

  ngOnInit() {
    this.querySub = this.route.queryParams.subscribe(params => {
      const searchParam = params['search'];
      if (searchParam !== undefined && searchParam !== null) {
        this.searchTerm.set(searchParam);
      }
    });
  }

  ngOnDestroy() {
    if (this.querySub) {
      this.querySub.unsubscribe();
    }
  }

  onSearch(event: Event) {
    const value = (event.target as HTMLInputElement).value;
    this.searchTerm.set(value);
    this.router.navigate([], {
      relativeTo: this.route,
      queryParams: { search: value || null },
      queryParamsHandling: 'merge'
    });
  }

  setCategory(category: string) {
    this.selectedCategory.set(category);
  }

  setStatus(status: string) {
    this.selectedStatus.set(status);
  }

  clearFilters() {
    this.searchTerm.set('');
    this.selectedCategory.set('All');
    this.selectedStatus.set('All');
    this.router.navigate([], {
      relativeTo: this.route,
      queryParams: { search: null },
      queryParamsHandling: 'merge'
    });
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
