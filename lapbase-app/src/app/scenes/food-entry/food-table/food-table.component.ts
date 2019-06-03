import { Component, OnInit } from '@angular/core';
import { IFood } from '../../../models';
import { PatientService } from '../../../services/patient.service';
@Component({
  selector: 'app-food-table',
  templateUrl: './food-table.component.html',
  styleUrls: ['./food-table.component.scss']
})
export class FoodTableComponent implements OnInit {
  foods:IFood[]
  constructor(private patientService:PatientService) { }

  ngOnInit() {
   this.foods = this.patientService.getFoodByPatients();
  }

}
