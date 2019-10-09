import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { HttpClient } from "@angular/common/http";
import { IReport, reporttype } from "../models/report";

@Injectable({
  providedIn: "root"
})
export class ReportService {
  constructor(private httpClient: HttpClient) {}

  getReports = async (): Promise<IReport[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Report")
      .toPromise<any>();
  };

  getLastAvailableDate = async(
    id: Number,
    organizationCode: Number,
    reportType: Number
    ): Promise<Date> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Report/lastDate/" +id + "/" + organizationCode + "/?reportType=" +reportType)
      .toPromise<any>();
  }

  getReportsById = async (
    id: Number,
    organizationCode: Number,
    reportType: Number,
    startDate: String,
    endDate: String
  ): Promise<IReport> => {
    return await this.httpClient
      .get(
        environment.LAPBASE_API_ADDRESS +
          "Report/" +
          id +
          "/" +
          organizationCode +
          "?startDate=" +
          startDate +
          "T00:00:00&endDate=" +
          endDate +
          "T00:00:00&reportType=" +
          reportType
      )
      .toPromise<any>();
  };
}
