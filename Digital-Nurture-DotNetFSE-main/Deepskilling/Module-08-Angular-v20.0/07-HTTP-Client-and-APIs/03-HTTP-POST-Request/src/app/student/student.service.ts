import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({providedIn:'root'})
export class StudentService{
 constructor(private http:HttpClient){}
 addStudent(data:any):Observable<any>{
   return this.http.post('https://jsonplaceholder.typicode.com/users',data);
 }
}
