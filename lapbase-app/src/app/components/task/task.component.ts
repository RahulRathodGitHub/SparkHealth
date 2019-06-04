import { ITask, TaskType } from './../../models/task';
import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})

export class TaskComponent implements OnInit {
  @Input() task: ITask;
  @Output() buttonHandler = new EventEmitter<string>();

  overDue: boolean;
  expanded: boolean;
  taskType: string;
  dueDate: string;

  constructor() {
  }

  ngOnInit() {
    this.overDue = new Date() > new Date(this.task.dueDate);
    this.expanded = false;
    this.taskType = TaskType[this.task.type];
    this.dueDate = this.task.dueDate.toString().substr(0,10);
  }

  onButtonClick() {
    if(!this.task.completed && !this.overDue)
    {
      this.buttonHandler.emit(this.task.id);
    }
  }

  onClick() {
    this.expanded = !this.expanded;
  }
}
