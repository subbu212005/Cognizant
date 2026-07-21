import { Component } from '@angular/core';
import { TestingComponent } from './testing/testing';

@Component({
 selector:'app-root',
 standalone:true,
 imports:[TestingComponent],
 templateUrl:'./app.html'
})
export class AppComponent{}
