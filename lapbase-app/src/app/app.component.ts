import { PatientService } from 'src/app/services';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { MsalService, BroadcastService } from '@azure/msal-angular';
import { Subscription } from 'rxjs';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, OnDestroy {
  loggedIn: boolean;
  public userInfo: any = null;
  private subscription: Subscription;
  title = 'LapBase';

  patientFirstName: string;
  patientLastName: string;
  patientImperialFlag: boolean;

  constructor(private patientService: PatientService, private broadcastService: BroadcastService) {
    this.patientService.getPatientLapbase().then(result => {
      this.patientFirstName = result.firstname;
      this.patientLastName = result.surname;
    });
  }

  ngOnInit() {
    this.broadcastService.subscribe('msal:loginFailure', (payload) => {
      this.loggedIn = false;
    });
    this.broadcastService.subscribe('msal:loginSuccess', (payload) => {
      this.loggedIn = true;
    });
  }

  ngOnDestroy() {
    this.broadcastService.getMSALSubject().next(1);
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }
}
