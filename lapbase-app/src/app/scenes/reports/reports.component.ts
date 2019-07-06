import { Component, OnInit } from "@angular/core";
@Component({
  selector: "app-reports",
  templateUrl: "./reports.component.html",
  styleUrls: ["./reports.component.scss"]
})
export class ReportsComponent implements OnInit {
  chartType = "";
  weightLossData = [{}];
  constructor() {}

  ngOnInit() {}

  chartOptions = {
    responsive: true
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
  chartLabels = ["January", "February", "Mars", "April"];

  onChartClick(event) {
    console.log(event);
  }

  setChartType(chartType) {
    this.chartType = chartType;
    this.chartData = [];
    this.chartData.push(this.chartDatas[this.chartType]);
  }
}
