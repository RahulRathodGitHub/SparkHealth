import { Injectable } from '@angular/core';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { IAppointment} from '../models';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor(private httpClient: HttpClient) {
  }

  // Get the appointments for a particular patient.
  getAppointments = async (): Promise<IAppointment[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointment/').toPromise<any>();
  }
}
