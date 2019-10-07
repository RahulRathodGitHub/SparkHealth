import { IReport } from 'src/app/models/report';
import { ReportService } from './../../services/report.service';
import { DashboardService} from './../../services/dashboard.service';
import { Component, OnInit } from '@angular/core';
import { IAppointment} from 'src/app/models';



@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }

  nextAppointment: IAppointment;
  report: IReport;
  chartData = {};
  chartLabels = {};

  constructor(private dashboardService: DashboardService, private reportService: ReportService) 
  {
    const organizationCode = 2;
    const patientId = 2756; //Ricky Perez

    this.dashboardService.getNextAppointment(patientId, organizationCode).then(result => this.nextAppointment = result);
    
  }

  getReport(typeOfReport)
  {
    this.reportService
      .getReportsById(
        2756,
        2,
        typeOfReport,
        (Date.now() - 30).toLocaleString(), // A month Ago
        Date.now().toLocaleString()         // Today
      )
      .then(p => {
        this.report = p;
        console.log(p);

        console.log(this.report.data);
        console.log(this.report.labels);

        var chartType;
        switch (typeOfReport) {
          case 0:
            chartType = "Weigth Loss (kg)";
            break;
          case 1:
            chartType = "EWL (kg)";
            break;
          case 2:
            chartType = "BMI";
            break;
        }

        this.chartData = [{ data: this.report.data, label: chartType }];
        this.chartLabels = this.report.labels;
      });
  }
  }



}
