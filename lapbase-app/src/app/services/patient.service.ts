import { IFoodIntakeList } from "./../models/foodIntakeList";
import { environment } from "./../../environments/environment";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { IPatient, IFood, IExercise, IFoodQuantity } from "../models";
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

  getPatientsLapbase = async (): Promise<string[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/GetPatientsLapbase")
      .toPromise<any>();
  };

  getPatientLapbaseById = async (
    patientId: number,
    organizationCode: number
  ): Promise<string[]> => {
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

  getFoodList = async (): Promise<IFood[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/Food/")
      .toPromise<any>();
  };

  // getFoodList = (): IFood[] => [
  //   {
  //     id: "1",
  //     name: "Burger",
  //     calorieCount: 295,
  //     unit: "piece"
  //   },
  //   {
  //     id: "2",
  //     name: "Onion",
  //     calorieCount: 40,
  //     unit: "piece"
  //   },
  //   {
  //     id: "3",
  //     name: "Uncle Keith's Kappuccino",
  //     calorieCount: 90,
  //     unit: "cup"
  //   },
  //   {
  //     id: "4",
  //     name: "White Bread",
  //     calorieCount: 96,
  //     unit: "slice"
  //   },
  //   {
  //     id: "5",
  //     name: "Apple",
  //     calorieCount: 44,
  //     unit: "apple"
  //   },
  //   {
  //     id: "6",
  //     name: "Banana",
  //     calorieCount: 107,
  //     unit: "banana"
  //   },

  //   {
  //     id: "7",
  //     name: "Tomato",
  //     calorieCount: 30,
  //     unit: "tomato"
  //   },
  //   {
  //     id: "8",
  //     name: "Roti",
  //     calorieCount: 50,
  //     unit: "slice"
  //   },
  //   {
  //     id: "9",
  //     name: "Rice",
  //     calorieCount: 40,
  //     unit: "cup"
  //   },
  //   {
  //     id: "10",
  //     name: "Halal Pork",
  //     calorieCount: 600,
  //     unit: "piece"
  //   },
  //   {
  //     id: "11",
  //     name: "Habib-Style Shwarma",
  //     calorieCount: 300,
  //     unit: "shwarma"
  //   },
  //   {
  //     id: "12",
  //     name: "Meat platter",
  //     calorieCount: 300,
  //     unit: "platter"
  //   },
  //   {
  //     id: "13",
  //     name: "Mooncake",
  //     calorieCount: 350,
  //     unit: "mooncake"
  //   },
  //   {
  //     id: "14",
  //     name: "HSP",
  //     calorieCount: 400,
  //     unit: "box"
  //   }
  // ];

  getExerciseByPatients = async (): Promise<IExercise[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Patient/Exercise/")
      .toPromise<any>();
  };

  /*(): IExercise[] => [
    {
      id: "1",
      name: "Swimming",
      calorieCount: 100,
      unit: "KJ/M",
      patientId: 1
    },
    {
      id: "2",
      name: "Jogging",
      calorieCount: 300,
      unit: "KJ/km",
      patientId: 1
    },
    {
      id: "3",
      name: "Running",
      calorieCount: 120,
      unit: "KJ/km",
      patientId: 1
    },
    {
      id: "5",
      name: "Boxing",
      calorieCount: 150,
      unit: "KJ/hour",
      patientId: 1
    }
  ];*/
}
