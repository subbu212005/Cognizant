import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-home',
  imports: [CommonModule, FormsModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home implements OnInit, OnDestroy {
  portalName = 'Student Course Portal';
  isPortalActive = true;
  searchTerm = '';
  message = '';
  coursesAvailable = 0;
  enrolledCount = 3;
  gpa = 3.8;

  /*
   * DIFFERENCE BETWEEN PROPERTY BINDING AND TWO-WAY DATA BINDING:
   * 
   * [property]="value" (One-way property binding):
   * Data flows in a single direction from the component class to the DOM.
   * If the component class updates the value, the DOM reflects this change.
   * However, any changes originating from the DOM (like user inputs or interactions) 
   * will NOT update the property in the component class automatically.
   *
   * [(ngModel)]="property" (Two-way data binding):
   * Data flows bi-directionally between the component class and the DOM.
   * Any change in the component class property updates the DOM element,
   * and any user input or change in the DOM element instantly updates the component property.
   * This is a combination of property binding `[ngModel]` and event binding `(ngModelChange)`.
   */

  onEnrollClick(): void {
    this.message = 'Enrollment opened!';
  }

  ngOnInit(): void {
    // Simulate fetching the count of available courses
    this.coursesAvailable = 12;
    console.log('HomeComponent initialised — courses loaded');
  }

  ngOnDestroy(): void {
    console.log('HomeComponent destroyed');
  }
}
