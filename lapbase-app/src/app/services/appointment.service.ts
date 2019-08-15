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

  getAppointment = async (id: number): Promise<IAppointment[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointment/' + id).toPromise<any>();
  }

  getAppointmentsDemo = (): IAppointment[] => {
    return [
      {id: "1", title: 'Appointment with Dr. A', start: new Date('2019-08-01T11:30:00'), end: new Date('2019-08-01T12:30:00'), patientId: 1},
      {id: "2", title: 'Routine checkup', start: new Date('2019-08-02T13:05:00'), end: new Date('2019-08-02T13:20:00'), patientId: 1}
    ];
  }

 
}
