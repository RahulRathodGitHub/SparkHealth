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
    reportType: Number,
    startDate: String,
    endDate: String
  ): Promise<WeightReport> => {
    return await this.httpClient
      .get(
        "https://localhost:5001/api/Report/35?startDate=1995-12-10T00:00:00&endDate=1999-02-14T00:00:00&reportType=0"
      )
      .toPromise<any>();
  };
}
