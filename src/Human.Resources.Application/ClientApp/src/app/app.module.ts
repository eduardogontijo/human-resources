import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import {TableModule} from 'primeng/table';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './shared/components/nav-menu/nav-menu.component';
import { HomeComponent } from './shared/components/home/home.component';
import { EmployeeReportComponent } from './views/employee-report/employee-report.component';
import {  EmployeeComponent } from './views/employee/employee.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    EmployeeReportComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'employee-report', component: EmployeeReportComponent },
      { path: 'employee', component: EmployeeComponent },
    ]),
    BrowserAnimationsModule,
    TableModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
