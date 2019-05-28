import { Component, OnInit, Input } from '@angular/core';
import { ITask } from 'src/app/models';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})
export class TaskComponent implements OnInit {
  @Input() task: ITask;
  overDue: boolean;

  constructor() {
  }

  ngOnInit() {
    this.overDue = new Date() > new Date(this.task.dueDate);
  }
}
