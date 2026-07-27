import { Routes } from '@angular/router';
import { authGuard } from './guards/auth.guard';

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
    loadComponent: () => import('./pages/courses-layout/courses-layout').then(m => m.CoursesLayoutComponent),
    canActivate: [authGuard],
    children: [
      {
        path: '',
        loadComponent: () => import('./pages/course-list/course-list').then(m => m.CourseListComponent)
      },
      {
        path: ':id',
        loadComponent: () => import('./pages/course-detail/course-detail').then(m => m.CourseDetailComponent)
      }
    ]
  },
  {
    path: 'profile',
    loadComponent: () => import('./pages/student-profile/student-profile').then(m => m.StudentProfileComponent),
    canActivate: [authGuard]
  },
  {
    path: 'enrollment',
    loadChildren: () => import('./features/enrollment/enrollment.module').then(m => m.EnrollmentModule),
    canActivate: [authGuard]
  },
  {
    path: 'enroll',
    redirectTo: 'enrollment/enroll',
    pathMatch: 'full'
  },
  {
    path: 'reactive-enroll',
    redirectTo: 'enrollment/reactive-enroll',
    pathMatch: 'full'
  },
  {
    path: 'not-found',
    loadComponent: () => import('./pages/not-found/not-found').then(m => m.NotFoundComponent)
  },
  {
    path: '**',
    redirectTo: 'not-found'
  }
];
