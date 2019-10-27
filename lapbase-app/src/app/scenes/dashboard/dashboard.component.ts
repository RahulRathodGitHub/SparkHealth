import { PatientService } from "./../../services/patient.service";
import { TaskService } from "./../../services/task.service";
import { IHealthStats } from "./../../models/healthStats";
import { IReport } from "src/app/models/report";
import { ReportService } from "./../../services/report.service";
import { DashboardService } from "./../../services/dashboard.service";
import { Component, OnInit } from "@angular/core";
import { IAppointment, IFood } from "src/app/models";
import { asRoughMinutes } from "@fullcalendar/core";
import { DatePipe } from "@angular/common";

@Component({
  selector: "app-dashboard",
  templateUrl: "./dashboard.component.html",
  styleUrls: ["./dashboard.component.scss"]
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
  patientInitBmi: number;

  constructor(  private datepipe: DatePipe,private dashboardService: DashboardService, private taskService: TaskService,private reportService: ReportService, private patientService: PatientService) 
  {
    const organizationCode = 2;
    const patientId = 2756; //Ricky Perez
    this.dashboardService
      .getNextAppointment(patientId, organizationCode)
      .then(result => {
        this.nextAppointment = result;
      });

    this.patientHealthStats = null;

    // We will only show reportType 0: Weight report on the dashboard.
    this.getReport(0);

    // Call to the services to get all the patient Health details.
    this.dashboardService.getPatientHealthDetails(patientId, organizationCode).then(result => {
      this.patientHealthStats = result;
      this.patientBMI = this.patientHealthStats.weight/(this.patientHeight)^2;
      this.patientInitBmi = this.patientHealthStats.initBMI;
    })

    // Get all available foods for the particular patient.
    this.patientService.getFoodList().then(foodChoiceList => {
      this.availableFoods = foodChoiceList;
    });

    // Get patient Height
    this.dashboardService.getPatientHeight().then(patientHeight =>{
      this.patientHeight = patientHeight;
    })

    // Get Patient's most consumed food for the entire month.
    this.dashboardService.getFoodOfTheMonth().then(foodOfTheMonthId =>{
      this.foodOfTheMonth = this.availableFoods.find(food => food.id === foodOfTheMonthId);
     

    })

    // Get calorie intake and burnt for today corresponding to the logged in patient.
    this.taskService.getTaskByDate(new Date().toISOString()).then(input =>{
      this.calorieBurn = input.caloriesLost;
      this.calorieIntake = input.caloriesGained
    })

  }

  // Helper method to format date.
  changeDateFormat(date: Date) {
    return this.datepipe.transform(date, "yyyy-MM-dd");
  }

  // Method to get the Report data from the backend.
  getReport(typeOfReport)
  {
    this.reportService
      .getReportsById(
        2756,
        2,
        typeOfReport,
        this.changeDateFormat(new Date(new Date().getDate() - 300000)), // A month Ago
        this.changeDateFormat(new Date()) // Today
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
        this.chartData = [
          { data: this.report.data2, label: this.report.dataLabel2 }
        ];

        this.chartLabels = this.report.timeLabels;
      });
  }

  // Variable representing the graph library's configuration.
  public lineChartColors: Array<any> = [
    {
      backgroundColor: "#ff9999",
      borderColor: "#cc003355",
      pointBackgroundColor: "#ff9999",
      pointBorderColor: "#cc0033",
      pointHoverBackgroundColor: "#fff",
      pointHoverBorderColor: "rgba(148,159,177,0.8)",
      borderWidth: "1",
      radius: "2",
      hoverRadius: "2"
    }
  ];
}
