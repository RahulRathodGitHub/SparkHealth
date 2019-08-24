import { Component, OnInit } from "@angular/core";
import { ACTIVE_INDEX } from '@angular/core/src/render3/interfaces/container';
import {IMyDrpOptions} from 'mydaterangepicker';
@Component({
  selector: "app-reports",
  templateUrl: "./reports.component.html",
  styleUrls: ["./reports.component.scss"]
})
export class ReportsComponent implements OnInit {
  chartType = "";
  dropdownActive = false; 
  weightLossData = [{}];
  myDateRangePickerOptions: IMyDrpOptions = {
    // other options...
    dateFormat: 'dd.mm.yyyy',
};

// For example initialize to specific date (09.10.2018 - 19.10.2018). It is also possible
// to set initial date range value using the selDateRange attribute.
today = Date.now;
private model: any = {beginDate: {year: 2019, month: 8, day: 24},
                         endDate: {year: 2019, month: 8, day: 24}};
  constructor() {}

  ngOnInit() {}

  chartOptions = {
    responsive: true,
    maintainAspectRatio: false
  };

  chartDatas = {
    weightLoss: { data: [330, 600, 260, 700], label: "Weight Loss" },
    bmi: { data: [120, 455, 100, 340], label: "BMI" },
    adverseEventSummary: {
      data: [45, 67, 800, 500],
      label: "Adverse Event Summary"
    },
    operationDetails: { data: [45, 67, 800, 500], label: "Operation Details" },
    progress: { data: [45, 67, 800, 500], label: "Progress" }
  };

  chartData = [{ data: [330, 600, 260, 700], label: "Weight Loss" }];
  chartLabels = ["January", "February", "March", "April"];

  onChartClick(event) {
    console.log(event);
  }

  setChartType(chartType) {
    this.chartType = chartType;
    this.chartData = [];
    this.chartData.push(this.chartDatas[this.chartType]);
  }
  public lineChartColors:Array<any> = [
    { // grey
      backgroundColor: 'rgba(148,159,177,0.2)',
      borderColor: 'rgba(148,159,177,1)',
      pointBackgroundColor: 'rgba(148,159,177,1)',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)'  
    },]

//   public dropdown(){
//     var dropdown = document.querySelector('.dropdown');
//   dropdown.addEventListener('click', function(event) {
//   event.stopPropagation();
//   dropdown.classList.toggle('is-active');
// });
//   }
    public drop(){
      this.dropdownActive = !this.dropdownActive;
    }
}
