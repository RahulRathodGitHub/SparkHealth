import { IFoodQuantity } from "./../models/foodQuantity";
import { Injectable } from "@angular/core";
import { ITask, TaskType, IFoodIntakeListDto, TaskInput } from "../models";
import { environment } from "./../../environments/environment";
import { HttpClient } from "@angular/common/http";
import { IFoodIntakeList } from "../models/foodIntakeList";

@Injectable({
  providedIn: "root"
})
export class TaskService {
  tempHardCodedData = {
    id: "db225c97-8515-4087-aeb9-f519cea4edea",
    patientId: 1,
    organizationCode: 1,
    dateAssigned: "2019-09-12T09:24:44.0948073+00:00",
    calories: 3000.0,
    weight: 70.0,
    foods: [
      {
        name: "Food1,Food 2,Food 3",
        quantity: "1,2,3",
        mealTime: "Breakfast"
      },
      {
        name: "Food1,Food 2,Food 3",
        quantity: "1,2,3",
        mealTime: "Lunch"
      },
      {
        name: "Food1,Food 2,Food 3",
        quantity: "1,2,3",
        mealTime: "Dinner"
      }
    ],
    exercises: {
      name: "push ups, Ex 2",
      quantity: "10, 20"
    }
  };

  constructor(private httpClient: HttpClient) {}

  getTasks = async (): Promise<ITask[]> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Task")
      .toPromise<any>();
  };

  getTask = async (id: string): Promise<ITask> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "Task/" + id)
      .toPromise<any>();
  };

  sendFoodIntake = async (
    selectedFoodQuantity: IFoodIntakeListDto
  ): Promise<IFoodIntakeListDto> => {
    return await this.httpClient
      .post(
        environment.LAPBASE_API_ADDRESS + "Task/FoodIntake/",
        selectedFoodQuantity
      )
      .toPromise<any>();
  };

  getTaskByDate = async (date: Date): Promise<TaskInput> => {
    return await this.httpClient
      .get(environment.LAPBASE_API_ADDRESS + "/TaskInput")
      .toPromise<any>();
  };
}
