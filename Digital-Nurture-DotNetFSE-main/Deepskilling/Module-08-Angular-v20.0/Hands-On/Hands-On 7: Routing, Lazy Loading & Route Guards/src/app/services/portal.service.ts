import { Injectable, signal } from '@angular/core';
import { StudentProfile } from '../models/course';

@Injectable({
  providedIn: 'root'
})
export class PortalService {
  // Student State
  private studentState = signal<StudentProfile>({
    name: 'Alex Rivera',
    email: 'alex.rivera@university.edu',
    studentId: 'U20248912',
    major: 'Computer Science & Engineering',
    gpa: 3.87,
    avatar: 'https://images.unsplash.com/photo-1534528741775-53994a69daeb?auto=format&fit=crop&q=80&w=256&h=256'
  });

  // Read-only access to student state
  readonly student = this.studentState.asReadonly();

  // Actions
  updateProfile(updatedProfile: Partial<StudentProfile>) {
    this.studentState.update(prev => ({
      ...prev,
      ...updatedProfile
    }));
  }
}

