import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor() { }

  getTasks() {
    return [
      {
        title: "Enter Data",
        description: "This task is for entering your calories Intake",
        dueDate: "2019-07-17",
        "isCompleted": false
      },
      {
        title: "Enter Data nicely",
        description: "This task is for entering your Calories Burned",
        dueDate: "2018-04-17",
        "isCompleted": false
      },
      {
        title: "Enter Data nicely",
        description: "Just another Task",
        dueDate: "2019-05-17",
        "isCompleted": true
      }
    ];
  }
}
