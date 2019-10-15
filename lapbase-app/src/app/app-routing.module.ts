import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {
  AccountComponent,
  AppointmentsComponent,
  DashboardComponent,
  FeedbackComponent,
  LoginComponent,
  NotFoundComponent,
  ReportsComponent,
  TasksComponent,
  TimelineComponent,
} from './scenes';
import { DeactivateGuard } from './scenes/tasks/deactivate-guard';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'account', component: AccountComponent },
  { path: 'appointments', component: AppointmentsComponent },
  { path: 'feedback', component: FeedbackComponent },
  { path: 'login', component: LoginComponent },
  { path: 'reports', component: ReportsComponent },
  { path: 'tasks', component: TasksComponent, canDeactivate:[DeactivateGuard] },
  { path: 'timeline', component: TimelineComponent },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
