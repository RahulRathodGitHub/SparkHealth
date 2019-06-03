import { Component, OnInit } from '@angular/core';
import { PatientService } from 'src/app/services';
import { IFood } from 'src/app/models';

@Component({
  selector: 'app-food-entry',
  templateUrl: './food-entry.component.html',
  styleUrls: ['./food-entry.component.scss']
})
export class FoodEntryComponent implements OnInit {
  foods: IFood[];

  constructor(patientService: PatientService) { 
    this.foods = patientService.getFoodByPatients();
  }

  ngOnInit() {
  }

}
