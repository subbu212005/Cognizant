import { Component } from '@angular/core';
import { E2EComponent } from './e2e/e2e';

@Component({
 selector:'app-root',
 standalone:true,
 imports:[E2EComponent],
 templateUrl:'./app.html'
})
export class AppComponent{}
