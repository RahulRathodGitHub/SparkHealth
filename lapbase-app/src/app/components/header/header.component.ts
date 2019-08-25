import { PatientService } from './../../services/patient.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  patientFirstName: String;
  patientLastName: String;

  constructor(private patientService: PatientService) {
    const organizationCode = 2;
    const patientId = 107057612;
  
    this.patientService.getPatientLapbaseById(patientId, organizationCode).then(result =>{
        this.patientFirstName = result[0]; 
        this.patientLastName = result[1];
    });
    
  }

  ngOnInit() {
  }

}
