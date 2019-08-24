import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "./app-routing.module";
import { HttpClientModule } from "@angular/common/http";
import { AppComponent } from "./app.component";
import { FormsModule } from "@angular/forms";
import { ChartsModule } from "ng2-charts";
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
    ExerciseEntryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ChartsModule,
    FullCalendarModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule {}
