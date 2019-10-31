import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { IReport, reporttype } from '../models/report';

@Injectable({
  providedIn: 'root'
})
export class ReportService {
  constructor(private httpClient: HttpClient) { }

  getLastAvailableDate = async (reportType: reporttype): Promise<Date> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Report/lastDate/?reportType=' + reportType).toPromise<any>();
  }

  getReports = async (reportType: reporttype, startDate: string, endDate: string): Promise<IReport> => {
    return await this.httpClient
      .get(
        environment.LAPBASE_API_ADDRESS +
        'Report/?startDate=' +
        startDate +
        'T00:00:00&endDate=' +
        endDate +
        'T00:00:00&reportType=' +
        reportType
      )
      .toPromise<any>();
  }
}
