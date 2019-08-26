import { PatientService } from 'src/app/services';
import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'LapBase';

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
}
