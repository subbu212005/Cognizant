import { TestBed } from '@angular/core/testing';
import { HttpClient, provideHttpClient, withInterceptors, HttpErrorResponse } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { errorHandlerInterceptor } from './error-handler.interceptor';
import { NotificationService } from '../services/notification.service';

describe('errorHandlerInterceptor', () => {
  let httpMock: HttpTestingController;
  let httpClient: HttpClient;
  let notificationService: NotificationService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: NotificationService,
          useValue: {
            show: vi.fn()
          }
        },
        provideHttpClient(withInterceptors([errorHandlerInterceptor])),
        provideHttpClientTesting()
      ]
    });

    httpMock = TestBed.inject(HttpTestingController);
    httpClient = TestBed.inject(HttpClient);
    notificationService = TestBed.inject(NotificationService);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should notify user and rethrow on HTTP error response', () => {
    httpClient.get('/api/error').subscribe({
      next: () => {
        throw new Error('should have failed');
      },
      error: (error: HttpErrorResponse) => {
        expect(error.status).toBe(500);
        expect(notificationService.show).toHaveBeenCalledWith(
          expect.stringContaining('Server Error: 500'),
          'error'
        );
      }
    });

    const req = httpMock.expectOne('/api/error');
    req.flush('Error occurred', { status: 500, statusText: 'Internal Server Error' });
  });

  it('should notify user and rethrow on network/client-side error event', () => {
    httpClient.get('/api/network-error').subscribe({
      next: () => {
        throw new Error('should have failed');
      },
      error: (error: HttpErrorResponse) => {
        expect(error.error instanceof ErrorEvent).toBe(true);
        expect(notificationService.show).toHaveBeenCalledWith(
          expect.stringContaining('Network Error: client error message'),
          'error'
        );
      }
    });

    const req = httpMock.expectOne('/api/network-error');
    req.error(new ErrorEvent('ClientError', { message: 'client error message' }));
  });
});
