import { Injectable } from '@angular/core';

@Injectable({providedIn:'root'})
export class CalculatorService{
 add(a:number,b:number){
  return a+b;
 }
}
