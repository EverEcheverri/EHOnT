import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {
  apiUrl: string = 'http://localhost:50408/api/employees';

  constructor(private http:HttpClient) { }

  getEmployees(){
    return this.http.get(this.apiUrl); 
  }
  getEmployeeById(id: number){
    const url = `${this.apiUrl}/${id}`
    return this.http.get(url); 
  }
}
