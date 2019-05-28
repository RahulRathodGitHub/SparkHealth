import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ITask } from 'src/app/models';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {

  // The tasks below is just a dummy data array, remove it while working on services
  private tasks: ITask[];

  constructor(service: TaskService) {
    this.tasks = service.getTasks();
  }
  ngOnInit() {
  }

}
