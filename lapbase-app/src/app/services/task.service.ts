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
        type: TaskType.FoodIntake,
        completed: false,
        overdue: false,
        dueDate: new Date(2019, 7, 17),
        patientId: 1,
        advisorId: 1,
      },
      {
        id: '2',
        type: TaskType.Exercise,
        completed: false,
        overdue: true,
        dueDate: new Date(2018, 4, 17),
        patientId: 1,
        advisorId: 1,
      },
      {
        id: '3',
        type: TaskType.Exercise,
        completed: true,
        overdue: false,
        dueDate: new Date(2019, 5, 17),
        patientId: 1,
        advisorId: 1,
      }
    ];
  }
}
