import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { PortalService } from '../../app/services/portal.service';

@Component({
  selector: 'app-student-profile',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './student-profile.html',
  styleUrl: './student-profile.css'
})
export class StudentProfileComponent implements OnInit {
  private fb = inject(FormBuilder);
  portalService = inject(PortalService);
  student = this.portalService.student;

  profileForm!: FormGroup;
  showSuccessAlert = false;

  ngOnInit() {
    const current = this.student();
    this.profileForm = this.fb.group({
      name: [current.name, [Validators.required, Validators.minLength(3)]],
      email: [current.email, [Validators.required, Validators.email]],
      studentId: [current.studentId, [Validators.required, Validators.pattern(/^U\d{8}$/)]], // Matches U followed by 8 digits
      major: [current.major, [Validators.required]]
    });
  }

  saveProfile() {
    if (this.profileForm.valid) {
      this.portalService.updateProfile(this.profileForm.value);
      this.showSuccessAlert = true;
      setTimeout(() => {
        this.showSuccessAlert = false;
      }, 4000);
    }
  }
}
