import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Course } from '../models/course';
import { Store } from '@ngrx/store';
import { CourseActions } from '../store/course/course.actions';
import { selectCourses } from '../store/course/course.selectors';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {
  private http = inject(HttpClient);
  private store = inject(Store);
  private apiUrl = 'http://localhost:3000/courses';

  // Read-only access to courses selected from store
  readonly courses = this.store.selectSignal(selectCourses);

  constructor() {
    // Explicit loadCourses dispatch is handled by page components or application bootstrap to avoid testing race conditions
  }

  // Load courses via action dispatch
  loadCourses() {
    this.store.dispatch(CourseActions.loadCourses());
  }

  // API methods called by Effects
  loadCoursesApi(): Observable<Course[]> {
    return this.http.get<Course[]>(this.apiUrl);
  }

  addCourseApi(course: Omit<Course, 'id' | 'progress' | 'image'> & { id?: string }): Observable<Course> {
    const newCourse: Course = {
      ...course,
      id: course.id || 'course_' + Date.now(),
      progress: course.status === 'completed' ? 100 : 0,
      image: 'https://images.unsplash.com/photo-1516321318423-f06f85e504b3?auto=format&fit=crop&q=80&w=400&h=250'
    };
    return this.http.post<Course>(this.apiUrl, newCourse);
  }

  updateCourseApi(courseId: string, updates: Partial<Course>): Observable<Course> {
    const course = this.getCourseById(courseId);
    const updatedCourse = { ...course, ...updates } as Course;
    return this.http.put<Course>(`${this.apiUrl}/${courseId}`, updatedCourse);
  }

  deleteCourseApi(courseId: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${courseId}`);
  }

  // Facade methods dispatching actions
  addCourse(course: Omit<Course, 'id' | 'progress' | 'image'> & { id?: string }) {
    this.store.dispatch(CourseActions.addCourse({ course }));
  }

  updateCourse(courseId: string, updates: Partial<Course>) {
    this.store.dispatch(CourseActions.updateCourse({ courseId, updates }));
  }

  deleteCourse(courseId: string) {
    this.store.dispatch(CourseActions.deleteCourse({ courseId }));
  }

  // Get course by ID synchronously from local state
  getCourseById(courseId: string): Course | undefined {
    const list = this.courses();
    const found = list.find(c => c.id.toLowerCase() === courseId.toLowerCase().trim());
    if (found) {
      return found;
    }
    if (/^\d+$/.test(courseId)) {
      const idx = parseInt(courseId, 10);
      if (idx >= 0 && idx < list.length) {
        return list[idx];
      }
    }
    return undefined;
  }
}
