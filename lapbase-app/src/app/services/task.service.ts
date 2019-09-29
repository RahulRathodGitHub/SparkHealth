import { Injectable } from '@angular/core';
import { ITask, IFoodIntakeListDto, TaskInput, Meal, MealTime } from '../models';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private httpClient: HttpClient) { }

  sendFoodIntake = async (selectedFoodQuantity: TaskInput): Promise<IFoodIntakeListDto> => {
    return await this.httpClient.post(environment.LAPBASE_API_ADDRESS + 'TaskInput/', selectedFoodQuantity).toPromise<any>();
  }

  // getTaskByDate = async (date: string): Promise<TaskInput> => {
  //   return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'TaskInput/Date/' + date).toPromise<any>();
  // }

  getTaskByDate = async (date: string): Promise<TaskInput> => {
    return {
      calories: 2,
      dateAssigned: new Date(),
      exercises: [],
      id: '',
      meals: [
        {
          foods: [],
          mealTime: MealTime.BREAKFAST
        },
        {
          foods: [],
          mealTime: MealTime.LUNCH
        },
        {
          foods: [],
          mealTime: MealTime.DINNER
        },
      ],
      weight: 0
    };
  }
}
