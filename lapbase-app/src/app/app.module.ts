import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "./app-routing.module";
import { HttpClientModule } from "@angular/common/http";
import { AppComponent } from "./app.component";
import { FormsModule } from "@angular/forms";
import { ChartsModule } from "ng2-charts";
import { MyDateRangePickerModule } from 'mydaterangepicker';
import { MyDatePickerModule } from 'mydatepicker';
import {
  HeaderComponent,
  SideMenuComponent,
  TaskComponent
} from "./components";
import {
  AccountComponent,
  AppointmentsComponent,
  DashboardComponent,
  ExerciseEntryComponent,
  ExerciseTableComponent,
  FoodEntryComponent,
  FoodTableComponent,
  TasksComponent,
  TimelineComponent,
  FeedbackComponent,
  ReportsComponent,
  LoginComponent,
  NotFoundComponent
} from "./scenes";

import { FullCalendarModule } from "@fullcalendar/angular"; //For incorporating the Calendar for Appointment functinality
import { DatePipe } from "@angular/common";
import { FoodChoicesComponent } from './scenes/tasks/food-choices/food-choices.component';
import { FoodChoiceComponent } from './scenes/tasks/food-choices/food-choice/food-choice.component';

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
    ExerciseEntryComponent,
    FoodChoicesComponent,
    FoodChoiceComponent
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
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule {}
