import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { IFood } from '../../../../models';
import { PatientService } from '../../../../services/patient.service';
@Component({
  selector: 'app-food-table',
  templateUrl: './food-table.component.html',
  styleUrls: ['./food-table.component.scss']
})
export class FoodTableComponent implements OnInit {
  @Input() alreadySelectedFood: string[];
  @Output() backHandler = new EventEmitter();
  @Output() submitHandler = new EventEmitter<IFood[]>();

  foods: IFood[];
  selectedFood: IFood[];
  name = '';
  calories = 0;
  unit = '';

  constructor(private patientService: PatientService) {
    this.selectedFood = new Array<IFood>();
  }

  ngOnInit() {
  }

  onSubmit() {
    this.submitHandler.emit(this.selectedFood);
  }

  onBack() {
    this.backHandler.emit();
  }
  toggleFood(food: IFood) {
    if (this.selectedFood.includes(food)) {
      this.selectedFood.splice(
        this.selectedFood.findIndex(fq => fq === food),
        1
      );
    } else {
      this.selectedFood.push(food);
    }
  }
  removeFood(foodId: string) {
    const index = this.foods.findIndex(f => f.id === foodId);
    this.foods.splice(index, 1);
  }
}
