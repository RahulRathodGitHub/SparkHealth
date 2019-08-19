import { Component, OnInit } from "@angular/core";
import { ACTIVE_INDEX } from '@angular/core/src/render3/interfaces/container';
@Component({
  selector: "app-reports",
  templateUrl: "./reports.component.html",
  styleUrls: ["./reports.component.scss"]
})
export class ReportsComponent implements OnInit {
  chartType = "";
  dropdownActive = false; 
  weightLossData = [{}];
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
      backgroundColor: '#ff9999',
      borderColor: '#cc0033',
      pointBackgroundColor: '#ff9999',
      pointBorderColor: '#cc0033',
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
