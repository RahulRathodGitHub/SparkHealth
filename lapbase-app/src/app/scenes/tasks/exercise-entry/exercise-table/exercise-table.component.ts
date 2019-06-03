import { Component, OnInit } from '@angular/core';
import { IExercise } from 'src/app/models';
import { PatientService } from 'src/app/services';
@Component({
  selector: 'app-exercise-table',
  templateUrl: './exercise-table.component.html',
  styleUrls: ['./exercise-table.component.scss']
})
export class ExerciseTableComponent implements OnInit {
  exercises: IExercise[];
  constructor(private patientService: PatientService) { }

  ngOnInit() {
   this.exercises = this.patientService.getExerciseByPatients();
  }
  addExercise() {
    // this.myExercise= new IExercise()
  }
}
