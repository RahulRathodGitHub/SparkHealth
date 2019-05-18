import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {

  // The tasks below is just a dummy data array, remove it while working on services
  _tasks = [
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

  /*constructor(private _tasks?: string[]) {
  }

  get tasks() {
    return this._tasks;
  }

  set tasks(value) {
    this._tasks = value;
  }*/

  ngOnInit() {
  }

}
