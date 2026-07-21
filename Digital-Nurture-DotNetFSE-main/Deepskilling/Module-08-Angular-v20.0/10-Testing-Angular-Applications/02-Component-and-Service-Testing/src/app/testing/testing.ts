import { Component } from '@angular/core';
import { CalculatorService } from './calculator.service';

@Component({
 selector:'app-testing',
 standalone:true,
 templateUrl:'./testing.html',
 styleUrl:'./testing.css'
})
export class TestingComponent{
 result:number;
 constructor(private service:CalculatorService){
  this.result=this.service.add(10,30);
 }
}
