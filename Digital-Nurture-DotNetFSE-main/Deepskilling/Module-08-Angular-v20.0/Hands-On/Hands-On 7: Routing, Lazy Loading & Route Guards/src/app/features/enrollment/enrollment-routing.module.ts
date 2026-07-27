import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EnrollmentFormComponent } from './enrollment-form/enrollment-form';
import { ReactiveEnrollmentFormComponent } from './reactive-enrollment-form/reactive-enrollment-form';
import { unsavedChangesGuard } from '../../guards/unsaved-changes.guard';

const routes: Routes = [
  {
    path: 'enroll',
    component: EnrollmentFormComponent,
    canDeactivate: [unsavedChangesGuard]
  },
  {
    path: 'reactive-enroll',
    component: ReactiveEnrollmentFormComponent,
    canDeactivate: [unsavedChangesGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EnrollmentRoutingModule {}
