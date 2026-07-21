import { Component } from '@angular/core';
import { ObservableComponent } from './observable/observable';

@Component({
  selector:'app-root',
  standalone:true,
  imports:[ObservableComponent],
  templateUrl:'./app.html'
})
export class AppComponent{}
