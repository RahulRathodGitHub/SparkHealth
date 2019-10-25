import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MsalGuard } from '@azure/msal-angular';
import {
  AccountComponent,
  AppointmentsComponent,
  DashboardComponent,
  FeedbackComponent,
  NotFoundComponent,
  ReportsComponent,
  TasksComponent,
  TimelineComponent,
} from './scenes';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent, canActivate: [MsalGuard] },
  { path: 'account', component: AccountComponent },
  { path: 'appointments', component: AppointmentsComponent ,canActivate: [MsalGuard] },
  { path: 'feedback', component: FeedbackComponent },
  { path: 'reports', component: ReportsComponent, canActivate: [MsalGuard] },
  { path: 'tasks', component: TasksComponent, canActivate: [MsalGuard] },
  { path: 'timeline', component: TimelineComponent, canActivate: [MsalGuard] },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
