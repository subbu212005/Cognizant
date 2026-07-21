import { Component } from '@angular/core';
import { UnitComponent } from './unit/unit';

@Component({
  selector:'app-root',
  standalone:true,
  imports:[UnitComponent],
  templateUrl:'./app.html'
})
export class AppComponent{}
