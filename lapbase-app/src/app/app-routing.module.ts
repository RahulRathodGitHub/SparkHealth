import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import {
  AccountComponent,
  AppointmentsComponent,
  DashboardComponent,
  FeedbackComponent,
  LoginComponent,
  NotFoundComponent,
  ReportsComponent,
  TasksComponent,
  TimelineComponent
} from "./scenes";
import { AuthGuard } from "./auth/auth.guard";
import { HomeLayoutComponent } from "./components/home-layout/home-layout.component";

const routes: Routes = [
  {
    path: "",
    component: HomeLayoutComponent,
    canActivate: [AuthGuard],
    children: [
      //{ path: '', redirectTo: '/dashboard', pathMatch: 'full' },
      { path: "dashboard", component: DashboardComponent },
      { path: "account", component: AccountComponent },
      { path: "appointments", component: AppointmentsComponent },
      { path: "feedback", component: FeedbackComponent },
      { path: "reports", component: ReportsComponent },
      { path: "tasks", component: TasksComponent },
      { path: "timeline", component: TimelineComponent }
    ]
  },
  { path: "login", component: LoginComponent },
  { path: "**", component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
