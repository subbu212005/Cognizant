import { Injectable } from '@angular/core';

@Injectable({
  providedIn:'root'
})
export class StoreService{
  count=0;

  increment(){
    this.count++;
  }
}
