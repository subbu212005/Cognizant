import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './components/header/header';
import { NotificationComponent } from './components/notification/notification';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner';
import { NotificationService } from './services/notification.service';
import { Store } from '@ngrx/store';
import { CourseActions } from './store/course/course.actions';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, NotificationComponent, LoadingSpinnerComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  // Providing NotificationService here creates a scoped instance that is shared across
  // all components within the AppComponent tree
  providers: [NotificationService]
})
export class AppComponent implements OnInit {
  title = 'Student-Course-Portal';
  private store = inject(Store);

  ngOnInit() {
    this.store.dispatch(CourseActions.loadCourses());
  }
}
