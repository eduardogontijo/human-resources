import { Component } from '@angular/core';

@Component({
  selector: 'app-employee-report-component',
  templateUrl: './employee-report.component.html'
})
export class EmployeeReportComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
