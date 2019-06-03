import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FoodEntryComponent } from './scenes/food-entry/food-entry.component';
import { FoodTableComponent } from './scenes/food-entry/food-table/food-table.component';
import { ExerciseTableComponent } from './scenes/food-entry/exercise-table/exercise-table.component';
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

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'account', component: AccountComponent },
  { path: 'appointments', component: AppointmentsComponent },
  { path: 'feedback', component: FeedbackComponent },
  { path: 'login', component: LoginComponent },
  { path: 'reports', component: ReportsComponent },
  { path: 'tasks', component: TasksComponent },
  { path: 'timeline', component: TimelineComponent },
  { path: 'foodentry', component: FoodEntryComponent },
  { path: 'foodtable', component: FoodTableComponent},
  { path: 'exercisetable', component: ExerciseTableComponent},
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
