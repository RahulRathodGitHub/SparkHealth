import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { HttpClient } from "@angular/common/http";
import { IReport, reporttype, WeightReport } from "../models/report";

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

  getReportsById = async (
    id: Number,
    reportType: reporttype,
    startDate: Date,
    endDate: Date
  ): Promise<WeightReport> => {
    return await this.httpClient
      .get(
        environment.LAPBASE_API_ADDRESS +
          "Report/" +
          id +
          "?startDate=" +
          startDate +
          "?endDate=" +
          endDate +
          "?reportType=" +
          reportType
      )
      .toPromise<any>();
  };
}
