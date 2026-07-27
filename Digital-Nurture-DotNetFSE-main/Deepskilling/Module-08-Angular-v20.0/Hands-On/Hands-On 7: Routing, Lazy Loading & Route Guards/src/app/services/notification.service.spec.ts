import { TestBed } from '@angular/core/testing';
import { NotificationService } from './notification.service';

describe('NotificationService', () => {
  let service: NotificationService;

  beforeEach(() => {
    vi.useFakeTimers();
    TestBed.configureTestingModule({
      providers: [NotificationService]
    });
    service = TestBed.inject(NotificationService);
  });

  afterEach(() => {
    vi.useRealTimers();
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should add a notification when show is called', () => {
    service.show('Test Message', 'success');
    const notifs = service.notifications();
    expect(notifs.length).toBe(1);
    expect(notifs[0].message).toBe('Test Message');
    expect(notifs[0].type).toBe('success');
  });

  it('should dismiss a notification when dismiss is called', () => {
    service.show('Test Message', 'info');
    const notifs = service.notifications();
    expect(notifs.length).toBe(1);
    const id = notifs[0].id;

    service.dismiss(id);
    expect(service.notifications().length).toBe(0);
  });

  it('should automatically dismiss after specified duration', () => {
    service.show('Auto Dismiss Message', 'warning', 1000);
    expect(service.notifications().length).toBe(1);

    vi.advanceTimersByTime(500);
    expect(service.notifications().length).toBe(1);

    vi.advanceTimersByTime(500);
    expect(service.notifications().length).toBe(0);
  });
});
