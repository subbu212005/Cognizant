import { Component } from '@angular/core';
import { OperatorsComponent } from './operators/operators';

@Component({
 selector:'app-root',
 standalone:true,
 imports:[OperatorsComponent],
 templateUrl:'./app.html'
})
export class AppComponent{}
