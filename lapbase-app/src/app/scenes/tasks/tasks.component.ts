import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {

  // The tasks below is just a dummy data array, remove it while working on services
  private _tasks;

  constructor(service: TaskService) {
    this._tasks = service.getTasks();
  }

  get tasks() {
    return this._tasks;
  }

  set tasks(value) {
    this._tasks = value;
  }

  ngOnInit() {
  }

}
