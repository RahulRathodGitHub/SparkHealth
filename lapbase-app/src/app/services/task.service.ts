import { Injectable } from '@angular/core';
import { TaskInput } from '../models';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private httpClient: HttpClient) { }

  sendFoodIntake = async (selectedFoodQuantity: TaskInput): Promise<TaskInput> => {
    return await this.httpClient.post(environment.LAPBASE_API_ADDRESS + 'TaskInput/', selectedFoodQuantity).toPromise<any>();
  }

  getTaskByDate = async (date: string): Promise<TaskInput> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'TaskInput/' + date).toPromise<any>();
  }
}
