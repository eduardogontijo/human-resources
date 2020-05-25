import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../shared/services/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent implements OnInit {

  public employees: any[];
  cols: any[];
  loading = true;

  constructor(
    private employeeService: EmployeeService
  ) {
  }

  loadHeader() {
    this.cols = [
      {field: 'empty', header: ''},
      { field: 'age', header: 'Ativo' },
      { field: 'name', header: 'Nome' },
      { field: 'birthDate', header: 'Data de Nasc.' },
      { field: 'age', header: 'Idade' },
      { field: 'email', header: 'Email' },
      { field: 'gender.name', header: 'Sexo' },
      { field: 'skills', header: 'Habilidades' },
    ];
  }

  loadEmployees() {
    this.loading = true;
    this.employeeService.get()
      .subscribe(result => {
        this.loading = false;
        if (result.success) {
          this.employees = result.data;
        }
      }, error => {
        this.loading = false;
        console.error(error);
      });
  }

  resolveCellGrid(cell: any, str: any) {
    const resolve = function (cells: any, strs: any, i = 0) {
      if (cells[strs.split('.')[i]]) {
        if ((strs.split('.').length - 1) > i) {
          return resolve(cells[strs.split('.')[i]], strs, ++i);
        }
        return cells[strs.split('.')[i]];
      }
      return '';
    };
    return resolve(cell, str);
  }

  ngOnInit() {
    this.loadEmployees();
    this.loadHeader();
  }
}
