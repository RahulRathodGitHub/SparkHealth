import { ITask } from './../../models/task';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})
export class TaskComponent implements OnInit {

  @Input() task: ITask;//This is the input for this component
  overDue: boolean;
  expanded: boolean;

  constructor() {
  }

  ngOnInit() {
    this.overDue = new Date() > new Date(this.task.dueDate);
    this.expanded = false;
  }

  onClick(){
    this.expanded = !this.expanded;
  }

  /*constructor(public _title: String, public _description: String, public _dueDate: Date) {
  }

  get title() {
    return this._title;
  }

  set title(value) {
    this._title = value;
  }

  get description() {
    return this._description;
  }

  set description(value) {
    this._description = value;
  }

  get dueDate() {
    return this._dueDate;
  }

  set dueDate(value) {
    this._dueDate = value;
  }*/


}
