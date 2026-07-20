import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentDataService {

  getStudentInfo(): string {
    return 'Student Service is provided using @Injectable decorator.';
  }

}
