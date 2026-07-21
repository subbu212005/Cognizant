import { Component } from '@angular/core';
import { StudentComponent } from './student/student';

@Component({
  selector:'app-root',
  standalone:true,
  imports:[StudentComponent],
  templateUrl:'./app.html'
})
export class AppComponent{}
