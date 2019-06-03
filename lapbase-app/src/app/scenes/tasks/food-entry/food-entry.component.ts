import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { PatientService } from 'src/app/services';
import { IFood, IFoodQuantity } from 'src/app/models';

@Component({
  selector: 'app-food-entry',
  templateUrl: './food-entry.component.html',
  styleUrls: ['./food-entry.component.scss']
})
export class FoodEntryComponent implements OnInit {
  @Output() nextHandler = new EventEmitter();
  @Output() backHandler = new EventEmitter();

  step: number;
  foods: IFood[];
  selectedFoodQuantity: IFoodQuantity[];

  constructor(patientService: PatientService) {
    this.step = 0;
    this.foods = patientService.getFoodByPatients();
    this.selectedFoodQuantity = [];
  }

  ngOnInit() {
  }

  onFoodSubmit(selectedFoodIds: string[]) {
    selectedFoodIds.forEach(id =>
      this.selectedFoodQuantity.push(
          {food: this.foods.find(f => f.id === id), quantity: 0}
        )
    );
    this.step--;
  }

  onSubmit() {
    // TODO Post entered data for task to api then (
      this.backHandler.emit();
    // )
  }

  onNext() {
    this.step++;
  }

  onCancel() {
    this.step--;
  }

  onBack() {
    this.backHandler.emit();
  }
}
