import { Component, OnInit } from "@angular/core";
import { ACTIVE_INDEX } from "@angular/core/src/render3/interfaces/container";
import { ReportService } from "src/app/services/report.service";
import { reporttype, WeightReport } from "src/app/models/report";
import { getLocaleDateTimeFormat } from "@angular/common";
@Component({
  selector: "app-reports",
  templateUrl: "./reports.component.html",
  styleUrls: ["./reports.component.scss"]
})
export class ReportsComponent implements OnInit {
  report: WeightReport;

  chartType = "";
  chartLabels;
  dropdownActive = false;
  weightLossData = [{}];
  constructor(private reportService: ReportService) {}

  ngOnInit() {
    //Retrieving weight data as default data when users visit the Report page
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, "0");
    var mm = String(today.getMonth() + 1).padStart(2, "0"); //January is 0!
    var yyyy = today.getFullYear() - 4;
    this.reportService
      .getReportsById(
        27,
        reporttype.Weight,
        new Date(yyyy + "-" + mm + "-" + dd),
        today
      )
      .then(p => (this.report = p));
    this.chartLabels = this.report.weightRecordedTime;
  }

  chartOptions = {
    responsive: true,
    maintainAspectRatio: false
  };

  chartData = [{ data: this.report.weight, label: "Weight Loss" }];

  onChartClick(event) {
    console.log(event);
  }

  setChartType(chartType) {
    this.chartType = chartType;

    // this.chartData = [];
    // this.chartData.push(this.chartDatas[this.chartType]);
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
}
