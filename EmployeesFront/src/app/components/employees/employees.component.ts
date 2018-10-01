import { Component, OnInit } from '@angular/core';
import { EmployeesService } from '../../services/employees.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  employees$: Object;
  constructor(private employeeService: EmployeesService) { }

  ngOnInit() {
    this.searchEmployees();
  }

  searchEmployees(){
    this.employeeService.getEmployees().subscribe(
      data => this.employees$ = data
    )
  }

  searchEmployeeById(){
    var employeeId = ((document.getElementById("employeeId") as HTMLInputElement).value);
    if(employeeId.length > 0 && Number(employeeId)){
      this.employeeService.getEmployeeById(Number(employeeId)).subscribe(
        data => this.employees$ = data
      )
    }
    else{
      this.searchEmployees();
    }    
  }
}
