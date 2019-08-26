import { Component, OnInit } from '@angular/core';
import { PatientService } from 'src/app/services';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.scss']
})
export class AccountComponent implements OnInit {

  constructor(private patientService: PatientService) {
  }

  ngOnInit() {
  }

}
