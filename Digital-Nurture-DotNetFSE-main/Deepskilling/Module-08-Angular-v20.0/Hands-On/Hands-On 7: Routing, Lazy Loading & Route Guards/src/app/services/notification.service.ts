import { Injectable, signal } from '@angular/core';

export interface Notification {
  id: string;
  message: string;
  type: 'success' | 'info' | 'warning' | 'error';
  timestamp: Date;
}

/**
 * NotificationService
 * 
 * NOTE ON ANGULAR INJECTION SCOPING:
 * By default, this service is provided as a singleton at the 'root' injector level.
 * 
 * However, to create a "scoped" instance of NotificationService, a component can register it 
 * in its metadata `providers: [NotificationService]`. 
 * 
 * Scoped service instance behavior:
 * 1. Scoped Lifecycle: The scoped service instance is created only when the registering 
 *    component is instantiated, and it is destroyed (and garbage-collected) when the 
 *    component is destroyed.
 * 2. Tree Isolation: Any component template or child component that injects this service 
 *    receives the same scoped instance, isolated from the rest of the application.
 * 3. State Isolation: Notifications sent to this scoped service will not bleed into the 
 *    global notification list, allowing for isolated, component-specific alerts (e.g. form-level alerts).
 */
@Injectable({
  providedIn: 'root'
})
export class NotificationService {
  private notificationsState = signal<Notification[]>([]);
  readonly notifications = this.notificationsState.asReadonly();

  show(message: string, type: 'success' | 'info' | 'warning' | 'error' = 'info', durationMs: number = 4000) {
    const id = 'notif_' + Math.random().toString(36).substring(2, 11) + '_' + Date.now();
    const newNotification: Notification = {
      id,
      message,
      type,
      timestamp: new Date()
    };
    
    this.notificationsState.update(notifs => [...notifs, newNotification]);

    setTimeout(() => {
      this.dismiss(id);
    }, durationMs);
  }

  dismiss(id: string) {
    this.notificationsState.update(notifs => notifs.filter(n => n.id !== id));
  }
}
