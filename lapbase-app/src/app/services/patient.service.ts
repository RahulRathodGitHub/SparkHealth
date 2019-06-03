import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPatient,IFood,IExercise } from '../models';



@Injectable({
  providedIn: 'root'
})
export class PatientService {

  constructor(private httpClient: HttpClient) {
  }

  getPatients = async (): Promise<IPatient[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient').toPromise<any>();
  }

  getPatient = async (id: number): Promise<IPatient> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/' + id).toPromise<any>();
  }

  getPatientsLapbase = async (): Promise<string[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/GetPatientsLapbase').toPromise<any>();
  }
  /*getFoodByPatient = async (): Promise<IFood[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Patient/getFood').toPromise<any>();
  }*/
  getFoodByPatients = (): IFood[] =>
  [
    {
      id: "1",
      name:"Potatos",
      calorieCount:100,
      unit:"KJ",
      patientId:1
    },
    {      
    id: "2",
    name:"Broccoli",
    calorieCount:300,
    unit:"KJ",
    patientId:1

    },
    {      
      id: "3",
      name:"Spinach",
      calorieCount:120,
      unit:"KJ",
      patientId:1
  
      },
      {      
        id: "5",
        name:"Oats",
        calorieCount:150,
        unit:"KJ",
        patientId:1
    
        },

  ]

  getExerciseByPatients = (): IExercise[] =>
  [
    {
      id: "1",
      name:"Swimming",
      calorieCount:100,
      unit:"KJ/M",
      patientId:1
    },
    {      
    id: "2",
    name:"Jogging",
    calorieCount:300,
    unit:"KJ/km",
    patientId:1

    },
    {      
      id: "3",
      name:"Running",
      calorieCount:120,
      unit:"KJ/km",
      patientId:1
  
      },
      {      
        id: "5",
        name:"Boxing",
        calorieCount:150,
        unit:"KJ/hour",
        patientId:1
    
        },

  ]
}
