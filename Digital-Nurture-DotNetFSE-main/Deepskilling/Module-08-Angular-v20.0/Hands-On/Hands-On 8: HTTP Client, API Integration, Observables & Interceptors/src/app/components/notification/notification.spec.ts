import { TestBed, ComponentFixture } from '@angular/core/testing';
import { NotificationComponent } from './notification';
import { NotificationService } from '../../services/notification.service';

describe('NotificationComponent', () => {
  let component: NotificationComponent;
  let fixture: ComponentFixture<NotificationComponent>;
  let notificationService: NotificationService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NotificationComponent],
      providers: [NotificationService]
    }).compileComponents();

    fixture = TestBed.createComponent(NotificationComponent);
    component = fixture.componentInstance;
    notificationService = TestBed.inject(NotificationService);
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render notifications from the service', () => {
    notificationService.show('Test Notification 1', 'success');
    fixture.detectChanges();

    const compiled = fixture.nativeElement as HTMLElement;
    const toast = compiled.querySelector('.notification-toast');
    expect(toast).toBeTruthy();
    expect(toast?.classList.contains('toast-success')).toBe(true);

    const text = compiled.querySelector('.toast-message');
    expect(text?.textContent).toContain('Test Notification 1');
  });

  it('should call dismiss on closing the notification toast', () => {
    const dismissSpy = vi.spyOn(notificationService, 'dismiss');
    
    notificationService.show('Test Close', 'info');
    fixture.detectChanges();

    const compiled = fixture.nativeElement as HTMLElement;
    const closeBtn = compiled.querySelector('.toast-close') as HTMLButtonElement;
    expect(closeBtn).toBeTruthy();

    closeBtn.click();
    fixture.detectChanges();

    expect(dismissSpy).toHaveBeenCalled();
  });
});
