import { Injectable } from '@angular/core';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { IAppointment} from '../models';
import { async } from '@angular/core/testing';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor(private httpClient: HttpClient) {
  }

  getAppointments = async (): Promise<IAppointment[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointment/').toPromise<any>();
  }

  getAppointmentsById = async (id: number, organizationCode: number): Promise<IAppointment[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointment/' + id + '/' + organizationCode).toPromise<any>();
  }
 
}
