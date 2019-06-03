import { ITask } from './../../models/task';
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

  constructor() {
  }

  ngOnInit() {
    this.overDue = new Date() > new Date(this.task.dueDate);
    this.expanded = false;
  }

  onButtonClick() {
    this.buttonHandler.emit(this.task.id);
  }

  onClick() {
    this.expanded = !this.expanded;
  }
}
