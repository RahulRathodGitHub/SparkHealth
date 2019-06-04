
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { PatientService } from 'src/app/services';
import { IExercise, IExerciseQuantity } from 'src/app/models';
@Component({
  selector: 'app-exercise-entry',
  templateUrl: './exercise-entry.component.html',
  styleUrls: ['./exercise-entry.component.scss']
})
export class ExerciseEntryComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
