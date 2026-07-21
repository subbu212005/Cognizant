import { Component } from '@angular/core';
import { StoreService } from './store.service';

@Component({
  selector:'app-counter',
  standalone:true,
  templateUrl:'./counter.html',
  styleUrl:'./counter.css'
})
export class CounterComponent{

  constructor(public store:StoreService){}

  increment(){
    this.store.increment();
  }
}
