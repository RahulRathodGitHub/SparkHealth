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

  /*getAppointments = async (): Promise<IAppointment[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointments/').toPromise<any>();
  }

  getAppointment = async (id: number): Promise<IAppointment> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointments/' + id).toPromise<any>();
  }*/

  getAppointmentsDemo = (): IAppointment[] => {
    return [
      {id: "1", title: 'Appointment with Dr. A', date:'2019-08-01', patientId: 1},
      {id: "2", title: 'Routine checkup', date:'2019-08-02', patientId: 1}
    ];
  }

 
}
