import { Component, OnInit } from '@angular/core';
import { IExercise } from '../../../models';
import { PatientService } from '../../../services/patient.service';
@Component({
  selector: 'app-exercise-table',
  templateUrl: './exercise-table.component.html',
  styleUrls: ['./exercise-table.component.scss']
})
export class ExerciseTableComponent implements OnInit {
  exercises:IExercise[]
  constructor(private patientService:PatientService) { }

  ngOnInit() {
   this.exercises = this.patientService.getExerciseByPatients();
  }

}