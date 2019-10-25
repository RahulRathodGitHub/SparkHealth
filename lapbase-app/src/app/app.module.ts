import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';
import { MyDateRangePickerModule } from 'mydaterangepicker';
import { MyDatePickerModule } from 'mydatepicker';
import { MsalModule, MsalInterceptor  } from '@azure/msal-angular';
import { environment } from 'src/environments/environment';
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
  NotFoundComponent
} from './scenes';

import { FullCalendarModule } from '@fullcalendar/angular';
import { DatePipe } from '@angular/common';
import { FoodChoicesComponent } from './scenes/tasks/food-choices/food-choices.component';
import { FoodChoiceComponent } from './scenes/tasks/food-choices/food-choice/food-choice.component';
import { ExerciseChoicesComponent } from './scenes/tasks/exercise-choices/exercise-choices.component';
import { ExerciseChoiceComponent } from './scenes/tasks/exercise-choices/exercise-choice/exercise-choice.component';
import { LogLevel } from 'msal';

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
    MyDatePickerModule,
    MsalModule.forRoot({
      clientID: environment.AZURE_AD_CLIENTID,
      popUp: true,
      redirectUri: environment.REDIRECT_URI,
      postLogoutRedirectUri: environment.POST_LOGOUT_REDIRECT_URI,
      authority: environment.AUTHORITY,
      validateAuthority: true,
      consentScopes: environment.CONSENT_SCOPES,
      level: LogLevel.Verbose,
      protectedResourceMap: [
          ['https://localhost:5001/api/Appointment', ['user_impersonation']],
          ['https://localhost:5001/api', ['user_impersonation']]
        ]
    }),
  ],
  providers: [DatePipe, {
    provide: HTTP_INTERCEPTORS,
    useClass: MsalInterceptor,
    multi: true
}],
  bootstrap: [AppComponent]
})
export class AppModule {}
