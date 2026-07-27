import { Component, inject } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { PortalService } from '../../services/portal.service';
import { AuthService } from '../../services/auth.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule, RouterLink, RouterLinkActive],
  templateUrl: './header.html',
  styleUrl: './header.css'
})
export class HeaderComponent {
  portalService = inject(PortalService);
  authService = inject(AuthService);
  
  student = this.portalService.student;
  isLoggedIn = this.authService.isLoggedIn;

  login() {
    this.authService.login();
  }

  logout() {
    this.authService.logout();
  }
}
