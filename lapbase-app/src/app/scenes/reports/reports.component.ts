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
  chartData = {};
  chartLabels = {};
  typeOfReport: Number;
  startDate: String;
  endDate: String;
  loading = false;
  chartType = '';
  dropdownActive = false;
  weightLossData = [{}];

  constructor(
    private datepipe: DatePipe,
    private reportService: ReportService
  ) {}

  ngOnInit() {
    //Setting default dates for when patient first visit page
    var twoYearsAgo = new Date();
    twoYearsAgo.setFullYear(twoYearsAgo.getFullYear() - 2);

    this.startDate = this.changeDateFormat(twoYearsAgo);
    this.endDate = this.changeDateFormat(new Date());

    //Retrieving weight data as default data when users visit the Report page
    this.setChartType("WeightLoss");
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
    console.log(typeof this.typeOfReport);

    this.getReport();
  }

  getReport() {
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
        console.log(p);

        console.log(this.report.data);
        console.log(this.report.labels);

        var chartType;
        switch (this.typeOfReport) {
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
        this.loading = false;
      });
  }

  changeDateFormat(date: Date) {
    return this.datepipe.transform(date, "yyyy-MM-dd");
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
    //console.log(this.changeDateFormat(new Date(event.jsdate)));
    this.startDate = this.changeDateFormat(new Date(event.jsdate));
    this.getReport();
  }
  public onEndDateChanged(event) {
    this.endDate = this.changeDateFormat(new Date(event.jsdate));
    this.getReport();
  }
  private startDatePlaceholder: string = "Start date";
  private endDatePlaceholder: string = "End date";
}
