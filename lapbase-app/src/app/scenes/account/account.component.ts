import { Component, OnInit } from "@angular/core";
import { PatientService } from "src/app/services";
import { Patient } from "src/app/models";
import { DatePipe } from "@angular/common";

@Component({
  selector: "app-account",
  templateUrl: "./account.component.html",
  styleUrls: ["./account.component.scss"]
})
export class AccountComponent implements OnInit {
  patientData;
  patientAge;

  constructor(
    private patientService: PatientService,
    private datePipe: DatePipe
  ) {}

  ngOnInit() {
    this.patientService.getPatientLapbaseById(2756, 2).then(pData => {
      this.patientData = pData;
      console.log(pData);
      console.log(this.patientData);
      this.calculateAge(this.patientData.birthDate);
    });
  }

  changeDateFormat(date: Date) {
    let tempDate = this.datePipe.transform(date, "dd-MMMM-yyyy").split("-");
    return tempDate[0] + " " + tempDate[1] + " " + tempDate[2];
  }

  calculateAge(date: Date) {
    this.patientAge = Math.abs(Date.now() - date.getTime());
  }
}
