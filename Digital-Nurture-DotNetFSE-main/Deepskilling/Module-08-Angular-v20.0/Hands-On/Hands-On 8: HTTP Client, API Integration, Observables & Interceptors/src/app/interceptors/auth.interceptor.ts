import { inject } from '@angular/core';
import { HttpInterceptorFn } from '@angular/common/http';
import { AuthService } from '../services/auth.service';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const authService = inject(AuthService);

  if (authService.isLoggedIn()) {
    const authReq = req.clone({
      headers: req.headers.set('Authorization', 'Bearer mock-token-12345')
    });
    return next(authReq);
  }

  return next(req);
};
