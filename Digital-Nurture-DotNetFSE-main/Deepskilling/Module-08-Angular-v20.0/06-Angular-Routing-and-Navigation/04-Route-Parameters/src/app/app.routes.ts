import { Routes } from '@angular/router';
import { StudentComponent } from './student/student';

export const routes: Routes = [
  { path: '', redirectTo: 'student/101', pathMatch: 'full' },
  { path: 'student/:id', component: StudentComponent }
];
