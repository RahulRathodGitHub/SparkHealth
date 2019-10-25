import { PatientService } from "src/app/services";
import { Component } from "@angular/core";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"]
})
export class AppComponent {
  title = "LapBase";

  patientFirstName: String;
  patientLastName: String;
  patientImperialFlag: Boolean;

  constructor(private patientService: PatientService) {
    const organizationCode = 2;
    const patientId = 2756;

    this.patientService
      .getPatientLapbaseById(patientId, organizationCode)
      .then(result => {
        console.log("Hey its "+ result.firstname);
         this.patientFirstName = result.firstname;
         this.patientLastName = result.surname;
      });
  }
}
