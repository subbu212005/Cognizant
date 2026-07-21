import { Component } from '@angular/core';

@Component({
 selector:'app-unit',
 standalone:true,
 templateUrl:'./unit.html',
 styleUrl:'./unit.css'
})
export class UnitComponent{
 title='Angular Unit Testing';
 subtitle='Unit Testing with Jasmine and Karma';
}
