import { Injectable, signal } from '@angular/core';
import { Course } from '../models/course';

@Injectable({
  providedIn: 'root'
})
export class CourseService {
  // Course Catalog State
  private coursesState = signal<Course[]>([
    {
      id: 'cs101',
      title: 'Advanced Web Development with Angular',
      instructor: 'Dr. Sarah Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Learn modern single-page application development. Covers components, routing, reactive forms, state management, and production optimization using Angular.',
      progress: 45,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1517694712202-14dd9538aa97?auto=format&fit=crop&q=80&w=400&h=250'
    },
    {
      id: 'cs102',
      title: 'Introduction to Artificial Intelligence',
      instructor: 'Prof. Michael Chen',
      credits: 4,
      category: 'Computer Science',
      description: 'Foundations of AI, search algorithms, knowledge representation, machine learning basics, neural networks, and applications in modern technology.',
      progress: 0,
      status: 'available',
      image: 'https://images.unsplash.com/photo-1677442136019-21780efad99a?auto=format&fit=crop&q=80&w=400&h=250'
    },
    {
      id: 'math201',
      title: 'Linear Algebra & Numerical Methods',
      instructor: 'Dr. Emily Watson',
      credits: 3,
      category: 'Mathematics',
      description: 'Vector spaces, linear transformations, matrices, determinants, eigenvalues, eigenvectors, and numerical methods for solving systems of equations.',
      progress: 100,
      status: 'completed',
      image: 'https://images.unsplash.com/photo-1635070041078-e363dbe005cb?auto=format&fit=crop&q=80&w=400&h=250'
    },
    {
      id: 'dsn104',
      title: 'User Experience & Interface Design',
      instructor: 'Marcus Aurelius',
      credits: 3,
      category: 'Design',
      description: 'Principles of human-computer interaction, prototyping, usability testing, layout structure, color theory, typography, and mobile-first design system logic.',
      progress: 80,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1541462608143-67571c6738dd?auto=format&fit=crop&q=80&w=400&h=250'
    },
    {
      id: 'bus302',
      title: 'Digital Marketing Strategies',
      instructor: 'Sophia Martinez',
      credits: 3,
      category: 'Business',
      description: 'Analyze online consumer behavior, SEO optimization, content strategies, brand management, data analytics, and advertising across digital platforms.',
      progress: 0,
      status: 'available',
      image: 'https://images.unsplash.com/photo-1460925895917-afdab827c52f?auto=format&fit=crop&q=80&w=400&h=250'
    },
    {
      id: 'cs203',
      title: 'Data Structures and Algorithms',
      instructor: 'Dr. Sarah Jenkins',
      credits: 4,
      category: 'Computer Science',
      description: 'Abstract data types, arrays, lists, stacks, queues, trees, graphs, sorting, searching, hashing, runtime analysis, and algorithmic complexity (Big O).',
      progress: 10,
      status: 'enrolled',
      image: 'https://images.unsplash.com/photo-1526374965328-7f61d4dc18c5?auto=format&fit=crop&q=80&w=400&h=250'
    }
  ]);

  // Read-only access to courses
  readonly courses = this.coursesState.asReadonly();

  // Actions
  addCourse(course: Omit<Course, 'id' | 'progress' | 'image'> & { id?: string }) {
    const newCourse: Course = {
      ...course,
      id: course.id || 'course_' + Date.now(),
      progress: course.status === 'completed' ? 100 : 0,
      image: 'https://images.unsplash.com/photo-1516321318423-f06f85e504b3?auto=format&fit=crop&q=80&w=400&h=250'
    };
    this.coursesState.update(courses => [...courses, newCourse]);
  }

  updateCourse(courseId: string, updates: Partial<Course>) {
    this.coursesState.update(courses =>
      courses.map(c => (c.id === courseId ? { ...c, ...updates } : c))
    );
  }

  getCourseById(courseId: string): Course | undefined {
    return this.coursesState().find(c => c.id === courseId);
  }
}
