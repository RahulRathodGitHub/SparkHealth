import { Injectable } from '@angular/core';
import { ITask } from '../models';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private httpClient: HttpClient) {
  }

  // getTasks = async (): Promise<ITask[]> => {
  //   return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Task').toPromise<any>();
  // }

  getTask = async (id: string): Promise<ITask> => {
    return await this.httpClient.get(environment.LAPBASE_API_ADDRESS + 'Task/' + id).toPromise<any>();
  }

  getTasks(): ITask[] {
    return [
      {
        id: '1',
        title: 'Enter Data',
        description: 'This task is for entering your calories Intake',
        dueDate: new Date(2019, 7, 17),
        isCompleted: false,
        whenCreated: new Date(2019, 7, 17)
      },
      {
        id: '2',
        title: 'Enter Data nicely',
        description: 'This task is for entering your Calories Burned',
        dueDate: new Date(2018, 4, 17),
        isCompleted: false,
        whenCreated: new Date(2019, 7, 17)
      },
      {
        id: '3',
        title: 'Enter Data very nicely',
        description: 'Just another Task',
        dueDate: new Date(2019, 5, 17),
        isCompleted: true,
        whenCreated: new Date(2019, 7, 17)
      }
    ];
  }
}
