import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { TasksComponent } from '.';

@Injectable()
export class DeactivateGuard implements CanDeactivate<TasksComponent> {

  canDeactivate(component: TasksComponent) {
    return component.canDeactivate();
  }
}