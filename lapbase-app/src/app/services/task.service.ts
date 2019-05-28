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
        title: 'Enter Data',
        description: 'gFASBFfwfrgreavegre,awrgaegeqrgeagegregeagrgwrfagreg,wrgaegargaer,ergr',
        dueDate: new Date(2019, 7, 17),
        isCompleted: false,
        whenCreated: new Date(2019, 7, 17)
      },
      {
        id: '2',
        title: 'Enter Data nicely',
        description: 'gFASafawfaff__________argrgre,awrgaegeqrgeagegregeagrgwrfag',
        dueDate: new Date(2018, 4, 17),
        isCompleted: false,
        whenCreated: new Date(2019, 7, 17)
      },
      {
        id: '3',
        title: 'Enter Data nicely',
        description: 'gFASafawfaff__________argrgre,awrgaegeqrgeagegregeagrgwrfag',
        dueDate: new Date(2019, 5, 17),
        isCompleted: true,
        whenCreated: new Date(2019, 7, 17)
      }
    ];
  }
}
