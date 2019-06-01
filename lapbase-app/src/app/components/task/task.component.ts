import { ITask } from './../../models/task';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})

export class TaskComponent implements OnInit {
  @Input() task: ITask;

  overDue: boolean;
  expanded: boolean;

  constructor() {
  }

  ngOnInit() {
    this.overDue = new Date() > new Date(this.task.dueDate);
    this.expanded = false;
  }

  onClick() {
    this.expanded = !this.expanded;
  }
}
