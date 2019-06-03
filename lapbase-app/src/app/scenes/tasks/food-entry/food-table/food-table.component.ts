import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { IFood } from '../../../../models';
import { PatientService } from '../../../../services/patient.service';
@Component({
  selector: 'app-food-table',
  templateUrl: './food-table.component.html',
  styleUrls: ['./food-table.component.scss']
})
export class FoodTableComponent implements OnInit {
  @Output() backHandler = new EventEmitter();
  @Output() submitHandler = new EventEmitter<string[]>();

  foods: IFood[];
  selectedFood: string[];

  constructor(private patientService: PatientService) {
  }

  ngOnInit() {
   this.foods = this.patientService.getFoodByPatients();
  }

  onSubmit() {
    // TODO Post entered data for task to api then (
      this.submitHandler.emit(this.selectedFood);
    // )
  }

  onBack() {
    this.backHandler.emit();
  }

}
