import { Injectable, inject, signal } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Course } from '../models/course';

@Injectable({
  providedIn: 'root'
})
export class CourseService {
  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:3000/courses';

  // Course Catalog State
  private coursesState = signal<Course[]>([]);

  // Read-only access to courses
  readonly courses = this.coursesState.asReadonly();

  constructor() {
    this.loadCourses();
  }

  // Load courses from the backend API
  loadCourses() {
    this.http.get<Course[]>(this.apiUrl).subscribe({
      next: (courses) => {
        this.coursesState.set(courses);
      },
      error: (error) => {
        console.error('Failed to load courses:', error);
      }
    });
  }

  // Add a new course
  addCourse(course: Omit<Course, 'id' | 'progress' | 'image'> & { id?: string }) {
    const newCourse: Course = {
      ...course,
      id: course.id || 'course_' + Date.now(),
      progress: course.status === 'completed' ? 100 : 0,
      image: 'https://images.unsplash.com/photo-1516321318423-f06f85e504b3?auto=format&fit=crop&q=80&w=400&h=250'
    };

    this.http.post<Course>(this.apiUrl, newCourse).subscribe({
      next: (created) => {
        this.coursesState.update(courses => [...courses, created]);
      },
      error: (error) => {
        console.error('Failed to add course:', error);
      }
    });
  }

  // Update course details
  updateCourse(courseId: string, updates: Partial<Course>) {
    const course = this.getCourseById(courseId);
    if (!course) return;

    const updatedCourse = { ...course, ...updates };

    this.http.put<Course>(`${this.apiUrl}/${courseId}`, updatedCourse).subscribe({
      next: (data) => {
        this.coursesState.update(courses =>
          courses.map(c => (c.id === courseId ? data : c))
        );
      },
      error: (error) => {
        console.error('Failed to update course:', error);
      }
    });
  }

  // Delete a course from the database
  deleteCourse(courseId: string) {
    this.http.delete<void>(`${this.apiUrl}/${courseId}`).subscribe({
      next: () => {
        this.coursesState.update(courses => courses.filter(c => c.id !== courseId));
      },
      error: (error) => {
        console.error('Failed to delete course:', error);
      }
    });
  }

  // Get course by ID synchronously from local state
  getCourseById(courseId: string): Course | undefined {
    const list = this.coursesState();
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
