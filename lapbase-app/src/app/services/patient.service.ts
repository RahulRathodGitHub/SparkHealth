import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPatient, IFood, IExercise, IFoodQuantity, Patient } from '../models';

@Injectable({
  providedIn: 'root'
})
export class PatientService {
  constructor(private httpClient: HttpClient) { }

  getPatient = async (): Promise<IPatient> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient').toPromise<any>();
  }

  getPatientImperialFlag = async (): Promise<boolean> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/Imperial').toPromise<any>();
  }

  getPatientLapbase = async (): Promise<Patient> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/GetPatientLapbase').toPromise<any>();
  }

  getFoodList = async (): Promise<IFood[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/Food/').toPromise<any>();
  }

  getExerciseList = async (): Promise<IExercise[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/Exercise/').toPromise<any>();
  }
}
