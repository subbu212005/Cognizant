import { inject } from '@angular/core';
import { HttpInterceptorFn, HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { NotificationService } from '../services/notification.service';

export const errorHandlerInterceptor: HttpInterceptorFn = (req, next) => {
  const notificationService = inject(NotificationService);

  return next(req).pipe(
    catchError((error: HttpErrorResponse) => {
      let errorMessage = 'An unexpected error occurred while communicating with the server.';
      
      if (error.error instanceof ErrorEvent) {
        // Client-side or network error
        errorMessage = `Network Error: ${error.error.message}`;
      } else if (error.status) {
        // Backend returned an unsuccessful response code
        errorMessage = `Server Error: ${error.status} - ${error.message || error.statusText}`;
      }
      
      console.error('HTTP Error caught by interceptor:', error);
      notificationService.show(errorMessage, 'error');
      
      return throwError(() => error);
    })
  );
};
