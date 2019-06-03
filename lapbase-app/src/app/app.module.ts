import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { TaskComponent } from './components/task/task.component';
import {
  AccountComponent,
  AppointmentsComponent,
  DashboardComponent,
  TasksComponent,
  TimelineComponent,
  FeedbackComponent,
  ReportsComponent,
  LoginComponent,
  NotFoundComponent,
} from './scenes';
import { FoodEntryComponent } from './scenes/food-entry/food-entry.component';
import { FoodTableComponent } from './scenes/food-entry/food-table/food-table.component';
import { ExerciseTableComponent } from './scenes/food-entry/exercise-table/exercise-table.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SideMenuComponent,
    AppointmentsComponent,
    TimelineComponent,
    TasksComponent,
    ReportsComponent,
    FeedbackComponent,
    LoginComponent,
    AccountComponent,
    DashboardComponent,
    NotFoundComponent,
    TaskComponent,
    FoodEntryComponent,
    FoodTableComponent,
    ExerciseTableComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
