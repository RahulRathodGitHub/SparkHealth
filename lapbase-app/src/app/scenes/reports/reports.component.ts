import { Component, OnInit } from '@angular/core';
import { ReportService } from 'src/app/services/report.service';
import { reporttype, IReport } from 'src/app/models/report';
import { DatePipe } from '@angular/common';
import { IMyDpOptions } from 'mydatepicker';

@Component({
  selector: 'app-reports',
  templateUrl: './reports.component.html',
  styleUrls: ['./reports.component.scss']
})
export class ReportsComponent implements OnInit {
  report: IReport;
  chartData = [];
  chartLabels = {};
  typeOfReport: number;
  startDate: string;
  endDate: string;
  loading = false;
  chartType = '';
  dropdownActive = false;
  weightLossData = [{}];
  public startDateModel: any;

  public lineChartColors: Array<any> = [
    {
      backgroundColor: '#ff999990',
      borderColor: '#cc003355',
      pointBackgroundColor: '#ff9999',
      pointBorderColor: '#cc0033',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)',
      borderWidth: '1',
      radius: '2',
      hoverRadius: '2'
    }
  ];

  public startDateOptions: IMyDpOptions = {
    // other options...
    dateFormat: 'dd.mm.yyyy'
  };
  public endDateOptions: IMyDpOptions = {
    // other options...
    dateFormat: 'dd.mm.yyyy'
  };

  startDatePlaceholder = 'Start date';
  endDatePlaceholder = 'End date';

  constructor(
    private datepipe: DatePipe,
    private reportService: ReportService
  ) { }

  chartOptions = {
    responsive: true,
    maintainAspectRatio: false
  };

  ngOnInit() {
    this.startDate = null;
    this.endDate = null;

    this.setChartType('EWL_WL');
  }

  setChartType(selectedChartType) {
    this.typeOfReport = +reporttype[selectedChartType];
    this.chartType = selectedChartType;
    this.getReport();
  }

  getReport() {
    if (this.startDate == null) {
      let lastAvailableDate = new Date();

      this.reportService
        .getLastAvailableDate(this.typeOfReport)
        .then(p => (lastAvailableDate = p));

      const twoYearsBeforeLatestDate = new Date();
      twoYearsBeforeLatestDate.setFullYear(lastAvailableDate.getFullYear() - 2);

      this.startDate = this.changeDateFormat(twoYearsBeforeLatestDate);
      this.startDateModel = {
        date: {
          year: twoYearsBeforeLatestDate.getFullYear(), month: twoYearsBeforeLatestDate.getMonth(),
          day: twoYearsBeforeLatestDate.getDay()
        }
      };
      this.endDate = this.changeDateFormat(lastAvailableDate);
    }

    this.loading = true;
    this.reportService
      .getReports(this.typeOfReport, this.startDate, this.endDate).then(p => {
        this.report = p;

        let chartType;
        switch (this.typeOfReport) {
          case 0:
            chartType = 'Weight Loss & EWL (kg)';
            break;
          case 1:
            chartType = 'BMI';
            break;
          case 2:
            chartType = 'Calorie';
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
    return this.datepipe.transform(date, 'yyyy-MM-dd');
  }

  public drop() {
    this.dropdownActive = !this.dropdownActive;
  }
  public onStartDateChanged(event) {

    this.startDate = this.changeDateFormat(new Date(event.jsdate));
    this.getReport();
  }
  public onEndDateChanged(event) {
    this.endDate = this.changeDateFormat(new Date(event.jsdate));
    this.getReport();
  }
}
