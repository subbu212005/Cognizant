import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { of } from 'rxjs';
import { map, filter } from 'rxjs/operators';

@Component({
 selector:'app-operators',
 standalone:true,
 imports:[CommonModule],
 templateUrl:'./operators.html',
 styleUrl:'./operators.css'
})
export class OperatorsComponent{
 values:number[]=[];
 constructor(){
  of(1,2,3,4,5).pipe(
    map(x=>x*10),
    filter(x=>x>=20)
  ).subscribe(v=>this.values.push(v));
 }
}
