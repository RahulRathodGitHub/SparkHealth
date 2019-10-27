import { IFoodIntakeList } from "./../models/foodIntakeList";
import { environment } from "./../../environments/environment";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { IPatient, IFood, IExercise, IFoodQuantity, Patient } from "../models";
import { async } from "@angular/core/testing";

@Injectable({
  providedIn: "root"
})
export class PatientService {
  constructor(private httpClient: HttpClient) {}

  getPatients = async (): Promise<IPatient[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient")
      .toPromise<any>();
  };

  getPatient = async (id: number): Promise<IPatient> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/" + id)
      .toPromise<any>();
  };

  getPatientImperialFlag = async (): Promise<Boolean> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/Imperial")
      .toPromise<any>();
  };

  getPatientsLapbase = async (): Promise<string[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/GetPatientsLapbase")
      .toPromise<any>();
  };

  getPatientLapbaseById = async (
    patientId: number,
    organizationCode: number
  ): Promise<Patient> => {
    return await this.httpClient
      .get(
        environment.LAPBASE_API_ADDRESS +
          "Patient/GetPatientLapbaseById/" +
          patientId +
          "/" +
          organizationCode
      )
      .toPromise<any>();
  };

  getPatientLapbaseByIdTest() {
    return {
      surname: "Perez",
      firstName: "Ricky",
      title: 1,
      street: "King St",
      suburb: "Bundoora",
      state: "Vic",
      postcode: 3754,
      homePhone: 12345678,
      workPhone: 8888888,
      mobilePhone: 87123456,
      emailAddress: "123@test.com",
      birthDate: new Date(),
      sex: "Male",
      race: "Human"
    };
  }
  getFoodList = async (): Promise<IFood[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/Food/")
      .toPromise<any>();
  };

  getExerciseList = async (): Promise<IExercise[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/Exercise/")
      .toPromise<any>();
  };
}
