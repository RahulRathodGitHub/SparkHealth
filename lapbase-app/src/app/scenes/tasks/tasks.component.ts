import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ITask } from 'src/app/models';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  private tasks: ITask[];

  constructor(service: TaskService) {
    service.getTasks().then(result => this.tasks = result.reverse());
    //The actual array that is provided from API is of a reversed order of what we expect
    //Thus, we reverse it up from the frontend
  }

  ngOnInit() {
  }

}
