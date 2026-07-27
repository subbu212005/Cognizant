import { Injectable, signal } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private authenticated = signal<boolean>(localStorage.getItem('isLoggedIn') === 'true');

  readonly isLoggedIn = this.authenticated.asReadonly();

  login() {
    this.authenticated.set(true);
    localStorage.setItem('isLoggedIn', 'true');
  }

  logout() {
    this.authenticated.set(false);
    localStorage.removeItem('isLoggedIn');
  }
}
