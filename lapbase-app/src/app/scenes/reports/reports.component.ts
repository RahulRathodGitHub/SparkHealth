import { Component, OnInit } from "@angular/core";
import { ACTIVE_INDEX } from "@angular/core/src/render3/interfaces/container";
import { ReportService } from "src/app/services/report.service";
import { reporttype, IReport } from "src/app/models/report";
import { DatePipe } from "@angular/common";
import { IMyDrpOptions } from "mydaterangepicker";
import { IMyDpOptions } from "mydatepicker";
import { SwitchView } from "@angular/common/src/directives/ng_switch";
@Component({
  selector: "app-reports",
  templateUrl: "./reports.component.html",
  styleUrls: ["./reports.component.scss"]
})
export class ReportsComponent implements OnInit {
  report: IReport;
  chartData = [];
  chartLabels = {};
  typeOfReport: Number;
  startDate: String;
  endDate: String;
  loading = false;
  chartType = "";
  dropdownActive = false;
  weightLossData = [{}];

  constructor(
    private datepipe: DatePipe,
    private reportService: ReportService
  ) {}

  ngOnInit() {
    this.startDate = null;
    this.endDate = null;

    //Retrieving weight data as default data when users visit the Report page
    this.setChartType("EWL_WL");
  }

  chartOptions = {
    responsive: true,
    maintainAspectRatio: false
  };

  onChartClick(event) {
    console.log(event);
  }

  setChartType(selectedChartType) {
    this.typeOfReport = +reporttype[selectedChartType];
    this.chartType = selectedChartType;
    this.getReport();
  }

  getReport() {
    if (this.startDate == null) {
      //Setting default dates for when patient first visit page
     

      var lastAvailableDate = new Date();

      this.reportService
        .getLastAvailableDate(2756, 2, this.typeOfReport)
        .then(p => (lastAvailableDate = p));

      var twoYearsBeforeLatestDate = new Date();
      twoYearsBeforeLatestDate.setFullYear(lastAvailableDate.getFullYear() - 2);

      this.startDate = this.changeDateFormat(twoYearsBeforeLatestDate);
      this.endDate = this.changeDateFormat(lastAvailableDate);
    }

    this.loading = true;
    this.reportService
      .getReportsById(
        2756,
        2,
        this.typeOfReport,
        //"1995-12-10",
        this.startDate,
        //"2005-02-14"
        this.endDate
      )
      .then(p => {
        this.report = p;
      

        var chartType;
        switch (this.typeOfReport) {
          case 0:
            chartType = "Weight Loss & EWL (kg)";
            break;
          case 1:
            chartType = "BMI";
            break;
          case 2:
            chartType = "Calorie";
            break;
        }

        this.chartData = [
          { data: this.report.data1, label: this.report.dataLabel1 }
        ];
        // Have to see the format for passing data2
        if (this.report.dataLabel2.length > 0) {
          this.chartData.push({
            data: this.report.data2,
            label: this.report.dataLabel2
          });
        }

        this.chartLabels = this.report.timeLabels;
        this.loading = false;
      });
  }

  changeDateFormat(date: Date) {
    return this.datepipe.transform(date, "yyyy-MM-dd");
  }
  public lineChartColors: Array<any> = [
    {
      backgroundColor: "#ff999990",
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
  public startDateOptions: IMyDpOptions = {
    // other options...
    dateFormat: "dd.mm.yyyy"
  };
  public endDateOptions: IMyDpOptions = {
    // other options...
    dateFormat: "dd.mm.yyyy"
  };
  public onStartDateChanged(event) {
   
    this.startDate = this.changeDateFormat(new Date(event.jsdate));
    this.getReport();
  }
  public onEndDateChanged(event) {
    this.endDate = this.changeDateFormat(new Date(event.jsdate));
    this.getReport();
  }
  startDatePlaceholder: string = "Start date";
  endDatePlaceholder: string = "End date";
}
