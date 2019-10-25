import { PatientService } from './../../services/patient.service';
import { TaskService } from './../../services/task.service';
import { IHealthStats } from './../../models/healthStats';
import { IReport } from 'src/app/models/report';
import { ReportService } from './../../services/report.service';
import { DashboardService} from './../../services/dashboard.service';
import { Component, OnInit } from '@angular/core';
import { IAppointment, IFood} from 'src/app/models';
import { asRoughMinutes } from '@fullcalendar/core';
import { DatePipe } from "@angular/common";


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {


  nextAppointment: IAppointment;
  report: IReport;
  chartData = [];
  chartLabels = [];
  patientHealthStats: IHealthStats;
  patientHeight: number;
  patientBMI:number;
  foodOfTheMonthId:string;
  foodOfTheMonth:IFood;
  calorieBurn:number;
  calorieIntake:number;
  availableFoods: IFood[];

  constructor(  private datepipe: DatePipe,private dashboardService: DashboardService, private taskService: TaskService,private reportService: ReportService, private patientService: PatientService) 
  {
    const organizationCode = 2;
    const patientId = 2756; //Ricky Perez
    this.dashboardService.getNextAppointment(patientId, organizationCode).then(result => {
      this.nextAppointment = result;
      
    });

    this.patientHealthStats = null;

    this.getReport(0);

    this.dashboardService.getPatientHealthDetails(patientId, organizationCode).then(result => {
      this.patientHealthStats = result;
      this.patientBMI = this.patientHealthStats.weight/(this.patientHeight)^2;
    })

    this.patientService.getFoodList().then(foodChoiceList => {
      this.availableFoods = foodChoiceList;
    });
    this.dashboardService.getPatientHeight().then(patientHeight =>{
      this.patientHeight = patientHeight;
    })
    this.dashboardService.getFoodOfTheMonth().then(foodOfTheMonthId =>{
      this.foodOfTheMonth = this.availableFoods.find(food => food.id === foodOfTheMonthId);
     

    })
    this.taskService.getTaskByDate(new Date().toISOString()).then(input =>{
      this.calorieBurn = input.caloriesLost;
      this.calorieIntake = input.caloriesGained
    })

  }


  changeDateFormat(date: Date) {
    return this.datepipe.transform(date, "yyyy-MM-dd");
  }
  getReport(typeOfReport)
  {
    this.reportService
      .getReportsById(
        2756,
        2,
        typeOfReport,
        this.changeDateFormat(new Date(new Date().getDate() - 300000)), // A month Ago
        this.changeDateFormat(new Date())         // Today
      )
      .then(p => {
        this.report = p;
      

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

        // data2 is the data for weight. This is hardcoded for dashboard as the dashboard is only supposed to show the weight graph.
        this.chartData = [{ data: this.report.data2, label: this.report.dataLabel2 }];
        
        this.chartLabels = this.report.timeLabels;
      });
  }

  public lineChartColors: Array<any> = [
    {
      backgroundColor: '#ff9999',
      borderColor: '#cc003355',
      pointBackgroundColor: '#ff9999',
      pointBorderColor: '#cc0033',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)',
      borderWidth: '1',
      radius:'2',
      hoverRadius:'2'
    }
  ];
  }
