import { Component } from '@angular/core';
import { CounterService } from './counter.service';

@Component({
 selector:'app-counter',
 standalone:true,
 templateUrl:'./counter.html',
 styleUrl:'./counter.css'
})
export class CounterComponent{

 constructor(public service:CounterService){}

 increment(){
  this.service.increment();
 }
}
