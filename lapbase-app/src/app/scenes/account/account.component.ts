import { Component, OnInit } from '@angular/core';
import { PatientService } from 'src/app/services';
import { IPatient } from 'src/app/models';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.scss']
})
export class AccountComponent implements OnInit {
  patients: IPatient[];
  patient: IPatient;
  patientsLapbase: string[];

  constructor(private patientService: PatientService) {
    patientService.getPatients().then((result) =>
      this.patients = result
    );
    patientService.getPatient(1).then((result) =>
      this.patient = result
    );
    patientService.getPatientsLapbase().then((result) =>
      this.patientsLapbase = result
    );
  }

  ngOnInit() {
  }

}
