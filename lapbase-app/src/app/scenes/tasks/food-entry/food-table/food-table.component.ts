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
  @Output() submitHandler = new EventEmitter<IFood[]>();

  foods: IFood[];
  selectedFood: IFood[];

  constructor(private patientService: PatientService) {
    this.selectedFood = new Array<IFood>();
    patientService.getFoodByPatients(1).then(result => 
        this.foods = result
      );
  }
  

  ngOnInit() {
  }

  onSubmit() {
    // TODO Post entered data for task to api then (

      this.submitHandler.emit(this.selectedFood);
    // )
  }

  onBack() {
    this.backHandler.emit();
  }
  toggleFood(food: IFood){
    if (this.selectedFood.includes(food)) {
      this.selectedFood.splice(this.selectedFood.findIndex(fq => fq === food), 1); 
    } else {
      this.selectedFood.push(food);
    }
  }

}
