import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './components/header/header';
import { NotificationComponent } from './components/notification/notification';
import { NotificationService } from './services/notification.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, NotificationComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  // Providing NotificationService here creates a scoped instance that is shared across
  // all components within the AppComponent tree (including pages, headers, and widgets),
  // keeping its lifecycle bound to the application's root component instead of the global scope.
  providers: [NotificationService]
})
export class AppComponent {
  title = 'Student-Course-Portal';
}


