import { Component, OnInit } from "@angular/core";
<<<<<<< HEAD
import { ACTIVE_INDEX } from "@angular/core/src/render3/interfaces/container";
import { ReportService } from "src/app/services/report.service";
import { reporttype, IReport } from "src/app/models/report";
import { DatePipe } from "@angular/common";

=======
import { ACTIVE_INDEX } from '@angular/core/src/render3/interfaces/container';
import {IMyDrpOptions} from 'mydaterangepicker';
import {IMyDpOptions} from 'mydatepicker';
>>>>>>> origin/TEAMD-120_Date_Pick_In_Report_Page
@Component({
  selector: "app-reports",
  templateUrl: "./reports.component.html",
  styleUrls: ["./reports.component.scss"]
})
export class ReportsComponent implements OnInit {
  report: IReport;
  chartData = {};
  chartLabels = {};

  loading = false;

  dropdownActive = false;
  weightLossData = [{}];
<<<<<<< HEAD
=======
                       constructor() {}
>>>>>>> origin/TEAMD-120_Date_Pick_In_Report_Page

  constructor(
    private datepipe: DatePipe,
    private reportService: ReportService
  ) {}

  ngOnInit() {
    this.setChartType("weightLoss");
  }

  chartOptions = {
    responsive: true,
    maintainAspectRatio: false
  };

  onChartClick(event) {
    console.log(event);
  }

  setChartType(chartType) {
    this.loading = true;
    var typeOfReport: reporttype;

    switch (chartType) {
      case "weightLoss":
        typeOfReport = reporttype["Weight"];
        break;
      // case "bmi" : number = reporttype['Bmi'];break;
      // case "ewl" : number = reporttype['Ewl'];break;
      // case "twl" : number = reporttype['Twl'];break;
      // case "progress" : number = reporttype['Progress'];break;
    }
<<<<<<< HEAD

    //Retrieving weight data as default data when users visit the Report page
    var today = new Date();

    var twoYearsAgo = new Date();
    twoYearsAgo.setFullYear(twoYearsAgo.getFullYear() - 2);

    this.reportService
      .getReportsById(
        2,
        2,
        typeOfReport,
        "1995-12-10",
        //this.datepipe.transform(twoYearsAgo, "yyyy-MM-dd")
        "1999-02-14"
        //this.datepipe.transform(today, "yyyy-MM-dd")
      )
      .then(p => {
        this.report = p;
        console.log(p);

        this.chartData = [{ data: this.report.data, label: "Weight Loss" }];
        this.chartLabels = this.report.label;
        this.loading = false;
      });
  }
  public lineChartColors: Array<any> = [
    {
      // grey
      backgroundColor: "rgba(148,159,177,0.2)",
      borderColor: "rgba(148,159,177,1)",
      pointBackgroundColor: "rgba(148,159,177,1)",
      pointBorderColor: "#fff",
      pointHoverBackgroundColor: "#fff",
      pointHoverBorderColor: "rgba(148,159,177,0.8)"
    }
  ];

  //   public dropdown(){
  //     var dropdown = document.querySelector('.dropdown');
  //   dropdown.addEventListener('click', function(event) {
  //   event.stopPropagation();
  //   dropdown.classList.toggle('is-active');
  // });
  //   }
  public drop() {
    this.dropdownActive = !this.dropdownActive;
  }
=======
    public startDateOptions: IMyDpOptions = {
      // other options...
      dateFormat: 'dd.mm.yyyy',
  };
  public endDateOptions: IMyDpOptions = {
    // other options...
    dateFormat: 'dd.mm.yyyy',
};
  public onStartDateChanged (event){
    console.log(new Date(event.jsdate));

  }
  public onEndDateChanged (event){
    console.log(event);
  }
  private startDatePlaceholder: string = 'Start date';
  private endDatePlaceholder: string = 'End date';
>>>>>>> origin/TEAMD-120_Date_Pick_In_Report_Page
}
