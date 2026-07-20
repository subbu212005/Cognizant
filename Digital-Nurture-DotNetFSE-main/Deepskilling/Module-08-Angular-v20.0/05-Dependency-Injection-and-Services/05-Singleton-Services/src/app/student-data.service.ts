import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  private count = 0;

  increment(): void {
    this.count++;
  }

  getCount(): number {
    return this.count;
  }

}
