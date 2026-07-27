import { TestBed } from '@angular/core/testing';
import { Router } from '@angular/router';
import { authGuard } from './auth.guard';
import { AuthService } from '../services/auth.service';
import { NotificationService } from '../services/notification.service';

describe('authGuard', () => {
  let authService: AuthService;
  let router: Router;
  let notificationService: NotificationService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        AuthService,
        {
          provide: Router,
          useValue: {
            navigate: vi.fn()
          }
        },
        {
          provide: NotificationService,
          useValue: {
            show: vi.fn()
          }
        }
      ]
    });

    authService = TestBed.inject(AuthService);
    router = TestBed.inject(Router);
    notificationService = TestBed.inject(NotificationService);
  });

  it('should allow navigation when user is logged in', () => {
    vi.spyOn(authService, 'isLoggedIn').mockReturnValue(true);

    const result = TestBed.runInInjectionContext(() => authGuard({} as any, {} as any));

    expect(result).toBe(true);
    expect(router.navigate).not.toHaveBeenCalled();
  });

  it('should prevent navigation and redirect to home when user is logged out', () => {
    vi.spyOn(authService, 'isLoggedIn').mockReturnValue(false);

    const result = TestBed.runInInjectionContext(() => authGuard({} as any, {} as any));

    expect(result).toBe(false);
    expect(notificationService.show).toHaveBeenCalledWith(
      'Please log in to access this page.',
      'error'
    );
    expect(router.navigate).toHaveBeenCalledWith(['/home']);
  });
});
