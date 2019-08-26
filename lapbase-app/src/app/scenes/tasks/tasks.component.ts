import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ITask, TaskType } from 'src/app/models';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  private tasks: ITask[];
  selectedTaskId: string;
  selectedTaskType: TaskType;
  step: number;

  constructor(private taskService: TaskService) {
    taskService.getTasks().then(result => this.tasks = result);
    this.step = 0;
  }

  onButtonClick(taskId: string) {
    this.selectedTaskId = taskId;
    this.selectedTaskType = this.tasks.find(t => t.id === taskId).type;
    this.step++;
  }

  next() {
    this.step++;
  }

  back() {
    this.step--;
    if (this.step === 0) {
      this.taskService.getTasks().then(result => this.tasks = result);
    }
  }

  ngOnInit() {
  }
}
