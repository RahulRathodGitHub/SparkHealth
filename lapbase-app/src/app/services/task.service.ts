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
        description: "gFASBFfwfrgreavegre,awrgaegeqrgeagegregeagrgwrfagreg,wrgaegargaer,ergr",
        dueDate: "2019-07-17",
        "isCompleted": false
      },
      {
        title: "Enter Data nicely",
        description: "gFASafawfaff__________argrgre,awrgaegeqrgeagegregeagrgwrfag",
        dueDate: "2018-04-17",
        "isCompleted": false
      },
      {
        title: "Enter Data nicely",
        description: "gFASafawfaff__________argrgre,awrgaegeqrgeagegregeagrgwrfag",
        dueDate: "2019-05-17",
        "isCompleted": true
      }
    ];
  }
}
