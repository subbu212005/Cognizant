import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    loadComponent: () => import('./pages/home/home.component').then(m => m.HomeComponent)
  },
  {
    path: 'courses',
    loadComponent: () => import('./pages/course-list/course-list.component').then(m => m.CourseListComponent)
  },
  {
    path: 'profile',
    loadComponent: () => import('./pages/student-profile/student-profile.component').then(m => m.StudentProfileComponent)
  },
  {
    path: '**',
    redirectTo: 'home'
  }
];
