import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ITask } from 'src/app/models';
import { Services } from '@angular/core/src/view';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  private tasks: ITask[];

  constructor(service: TaskService) {
    // service.getTasks().then(result => this.tasks = result);
    this.tasks = service.getTasks();
  }

  ngOnInit() {
  }

}
