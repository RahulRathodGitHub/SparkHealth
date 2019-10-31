import { Component, OnInit } from '@angular/core';
import { PatientService } from 'src/app/services';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.scss']
})
export class AccountComponent implements OnInit {
  patientData;
  patientAge;

  constructor(
    private patientService: PatientService,
    private datePipe: DatePipe
  ) {}

  ngOnInit() {
    // Retrieving data from backend through patient service
    this.patientService.getPatientLapbase().then(pData => {
      this.patientData = pData;

      this.calculateAge(this.patientData.birthdate);
    });
  }

  changeDateFormat(date: Date) {
    // Returns date in day/month/year format
    return this.datePipe.transform(date, 'dd/MM/yyyy');
  }

  getBirthDate() {
    // Get BirthDate in format:  "5 September 1996"
    const tempDate = this.datePipe
      .transform(this.patientData.birthdate, 'dd-MMMM-yyyy')
      .split('-');
    return tempDate[0] + ' ' + tempDate[1] + ' ' + tempDate[2];
  }

  calculateAge(date: Date) {
    // Calculate age from their birthday to today's date
    const timeDiff = Math.abs(Date.now() - new Date(date).getTime());
    this.patientAge = Math.floor(timeDiff / (1000 * 3600 * 24) / 365.25);
  }
}
