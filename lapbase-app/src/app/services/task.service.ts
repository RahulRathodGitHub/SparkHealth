import { IFoodQuantity } from './../models/foodQuantity';
import { Injectable } from '@angular/core';
import { ITask, TaskType } from '../models';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private httpClient: HttpClient) {
  }

  getTasks = async (): Promise<ITask[]> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Task').toPromise<any>();
  }

  getTask = async (id: string): Promise<ITask> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Task/' + id).toPromise<any>();
  }

}
