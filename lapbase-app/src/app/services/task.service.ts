import { Injectable } from '@angular/core';
import { ITask } from '../models';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor() { }

  getTasks(): ITask[] {
    return [
      {
        id: '1',
        title: "Enter Data",
        description: "This task is for entering your calories Intake",
        dueDate: new Date(2019, 7, 17),
        isCompleted: false,
        whenCreated: new Date(2019, 7, 17)
      },
      {
        id: '2',
        title: "Enter Data nicely",
        description: "This task is for entering your Calories Burned",
        dueDate: new Date(2018, 4, 17),
        isCompleted: false,
        whenCreated: new Date(2019, 7, 17)
      },
      {
        id: '3',
        title: "Enter Data very nicely",
        description: "Just another Task",
        dueDate: new Date(2019, 5, 17),
        isCompleted: true,
        whenCreated: new Date(2019, 7, 17)
      }
    ];
  }
}
