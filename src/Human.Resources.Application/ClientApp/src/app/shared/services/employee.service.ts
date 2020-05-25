import { HttpClient } from '@angular/common/http';
import { BaseService } from './base';
import { EmployeeModel } from '../../model/employee/employee.model';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class EmployeeService extends BaseService<EmployeeModel, EmployeeModel> {
  constructor(
    public http: HttpClient
  ) {
    super(http);
    this.endpoint = 'employee';
  }

  get(): Observable<any> {
    return this.getRequest<any>();
  }
}
