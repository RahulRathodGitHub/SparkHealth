import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPatient } from '../models';

@Injectable({
  providedIn: 'root'
})
export class PatientService {

  constructor(private httpClient: HttpClient) {
  }

  getPatients = async (): Promise<IPatient[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient').toPromise<any>();
  }

  getPatient = async (id: string): Promise<IPatient> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/' + id).toPromise<any>();
  }

  getPatientsLapbase = async (): Promise<string[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/GetPatientsLapbase').toPromise<any>();
  }
}
