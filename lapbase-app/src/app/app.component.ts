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

  constructor(private patientService: PatientService, private broadcastService: BroadcastService, private authService: MsalService) {
    const organizationCode = 2;
    const patientId = 2756;

    this.patientService.getPatientLapbaseById(patientId, organizationCode).then(result => {
      this.patientFirstName = result[0];
      this.patientLastName = result[1];
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
