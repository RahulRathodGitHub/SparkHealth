import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';
import { MyDateRangePickerModule } from 'mydaterangepicker';
import { MyDatePickerModule } from 'mydatepicker';
import {
  HeaderComponent,
  SideMenuComponent,
} from './components';
import {
  AccountComponent,
  AppointmentsComponent,
  DashboardComponent,
  ExerciseEntryComponent,
  ExerciseTableComponent,
  TasksComponent,
  TimelineComponent,
  FeedbackComponent,
  ReportsComponent,
  LoginComponent,
  NotFoundComponent
} from './scenes';

import { FullCalendarModule } from '@fullcalendar/angular';
import { DatePipe } from '@angular/common';
import { FoodChoicesComponent } from './scenes/tasks/food-choices/food-choices.component';
import { FoodChoiceComponent } from './scenes/tasks/food-choices/food-choice/food-choice.component';
import { ExerciseChoicesComponent } from './scenes/tasks/exercise-choices/exercise-choices.component';
import { ExerciseChoiceComponent } from './scenes/tasks/exercise-choices/exercise-choice/exercise-choice.component';
import { DeactivateGuard } from './scenes/tasks/deactivate-guard';

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
    ExerciseTableComponent,
    ExerciseEntryComponent,
    FoodChoicesComponent,
    FoodChoiceComponent,
    ExerciseChoicesComponent,
    ExerciseChoiceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ChartsModule,
    FullCalendarModule,
    MyDateRangePickerModule,
    MyDatePickerModule
  ],
  providers: [DatePipe, DeactivateGuard],
  bootstrap: [AppComponent]
})
export class AppModule {}
