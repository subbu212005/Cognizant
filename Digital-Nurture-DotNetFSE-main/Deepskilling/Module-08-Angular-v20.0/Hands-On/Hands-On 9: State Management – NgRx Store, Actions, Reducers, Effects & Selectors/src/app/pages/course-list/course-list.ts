import { Component, inject, signal, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseService } from '../../services/course.service';
import { EnrollmentService } from '../../services/enrollment.service';
import { CourseCardComponent } from '../../components/course-card/course-card';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription, combineLatest, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { toObservable } from '@angular/core/rxjs-interop';
import { Store } from '@ngrx/store';
import { selectCourses } from '../../store/course/course.selectors';
import { CourseActions } from '../../store/course/course.actions';
import { Course } from '../../models/course';

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
  private store = inject(Store);

  courses$ = this.store.select(selectCourses);
  private querySub!: Subscription;

  // Filters State (as local signals)
  searchTerm = signal('');
  selectedCategory = signal('All');
  selectedStatus = signal('All');

  // Categories list for filter UI
  categories = ['All', 'Computer Science', 'Mathematics', 'Design', 'Business'];

  // Statuses list for filter UI
  statuses = ['All', 'Available', 'Enrolled', 'Completed'];

  // Filtered Course Catalog via RxJS
  filteredCourses$: Observable<Course[]> = combineLatest([
    this.courses$,
    toObservable(this.searchTerm),
    toObservable(this.selectedCategory),
    toObservable(this.selectedStatus)
  ]).pipe(
    map(([courses, search, cat, stat]) => {
      const searchLower = (search || '').toLowerCase().trim();
      const statusLower = (stat || '').toLowerCase();
      const catVal = cat || 'All';

      if (!courses) return [];

      return courses.filter(course => {
        const matchesSearch = !searchLower ||
                              (course.title && course.title.toLowerCase().includes(searchLower)) || 
                              (course.description && course.description.toLowerCase().includes(searchLower)) ||
                              (course.instructor && course.instructor.toLowerCase().includes(searchLower));
        const matchesCategory = catVal === 'All' || course.category === catVal;
        const matchesStatus = statusLower === 'all' || (course.status && course.status.toLowerCase() === statusLower);

        return matchesSearch && matchesCategory && matchesStatus;
      });
    })
  );

  ngOnInit() {
    this.store.dispatch(CourseActions.loadCourses());
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

  delete(courseId: string) {
    const course = this.courseService.getCourseById(courseId);
    const title = course ? `"${course.title}"` : 'this course';
    if (confirm(`Are you sure you want to delete ${title} from the catalog?`)) {
      this.courseService.deleteCourse(courseId);
    }
  }
}
