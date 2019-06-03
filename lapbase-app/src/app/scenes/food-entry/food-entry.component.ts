import { Component, OnInit } from '@angular/core';
import { PatientService } from 'src/app/services';
import { IFood, IExercise } from 'src/app/models';

@Component({
  selector: 'app-food-entry',
  templateUrl: './food-entry.component.html',
  styleUrls: ['./food-entry.component.scss']
})
export class FoodEntryComponent implements OnInit {
  foods: IFood[];
  exercises:IExercise[];
  myfoods: [];
  constructor(patientService: PatientService) { 
    this.foods = patientService.getFoodByPatients();
    this.exercises = patientService.getExerciseByPatients();
  }

  ngOnInit() {
  }

}
