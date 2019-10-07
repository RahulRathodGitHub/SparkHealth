import { IAppointment } from 'src/app/models';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { environment } from "./../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  constructor(private httpClient: HttpClient) {}

  getNextAppointment = async (patientId, organizationCode): Promise<IAppointment> => {
    //TODO Enter the patient id and the organization code throught the token
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Appointment/Next/' + patientId +"/"+ organizationCode).toPromise<any>();
  }
}
