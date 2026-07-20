import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  getCollegeName(): string {
    return 'Vignan University';
  }

}
