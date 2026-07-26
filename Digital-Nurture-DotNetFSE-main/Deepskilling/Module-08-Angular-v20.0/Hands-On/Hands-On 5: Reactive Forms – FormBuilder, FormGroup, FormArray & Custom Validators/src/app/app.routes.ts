import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    loadComponent: () => import('./pages/home/home').then(m => m.HomeComponent)
  },
  {
    path: 'courses',
    loadComponent: () => import('./pages/course-list/course-list').then(m => m.CourseListComponent)
  },
  {
    path: 'profile',
    loadComponent: () => import('./pages/student-profile/student-profile').then(m => m.StudentProfileComponent)
  },
  {
    path: 'enroll',
    loadComponent: () => import('./pages/enrollment-form/enrollment-form').then(m => m.EnrollmentFormComponent)
  },
  {
    path: 'reactive-enroll',
    loadComponent: () => import('./pages/reactive-enrollment-form/reactive-enrollment-form').then(m => m.ReactiveEnrollmentFormComponent)
  },
  {
    path: '**',
    redirectTo: 'home'
  }
];
