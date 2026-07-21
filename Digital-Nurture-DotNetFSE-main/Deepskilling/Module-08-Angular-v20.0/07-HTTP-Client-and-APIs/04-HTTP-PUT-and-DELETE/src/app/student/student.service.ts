import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({providedIn:'root'})
export class StudentService{
 constructor(private http:HttpClient){}

 updateStudent(id:number,data:any):Observable<any>{
  return this.http.put('https://jsonplaceholder.typicode.com/users/'+id,data);
 }

 deleteStudent(id:number):Observable<any>{
  return this.http.delete('https://jsonplaceholder.typicode.com/users/'+id);
 }
}
