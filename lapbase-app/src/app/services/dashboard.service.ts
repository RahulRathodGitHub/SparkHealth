import { IHealthStats } from './../models/healthStats';
import { IAppointment } from 'src/app/models';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from './../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  constructor(private httpClient: HttpClient) { }

  // Get the patient's next appointment.
  getNextAppointment = async (): Promise<IAppointment> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointment/Next').toPromise<any>();
  }

  // Get all available health stats for the patient.
  getPatientHealthDetails = async (): Promise<IHealthStats> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Report/healthStats')
      .toPromise<any>();
  }

  // Get the patient's height
  getPatientHeight = async (): Promise<number> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/Height').toPromise<any>();
  }

  // Get the patient's most consumed food in a particular month.
  getFoodOfTheMonth = async (): Promise<string> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'TaskInput/foodOfTheMonth').toPromise<any>();
  }
}
