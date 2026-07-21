import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Observable, of } from 'rxjs';

@Component({
  selector:'app-observable',
  standalone:true,
  imports:[CommonModule],
  templateUrl:'./observable.html',
  styleUrl:'./observable.css'
})
export class ObservableComponent{
  values:number[]=[];

  constructor(){
    const obs:Observable<number>=of(10,20,30);
    obs.subscribe(value=>this.values.push(value));
  }
}
