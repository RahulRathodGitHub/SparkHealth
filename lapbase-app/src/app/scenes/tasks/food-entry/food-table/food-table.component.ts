import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { IFood } from '../../../../models';
import { PatientService } from '../../../../services/patient.service';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
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
  name: string = '';
  calories: number= 0;
  unit: string ='';

  constructor(private patientService: PatientService) {
    this.selectedFood = new Array<IFood>();
  }

  ngOnInit() {
    this.patientService.getFoodByPatients(1).then(result => {
      if (this.alreadySelectedFood) {
        this.foods = result.filter(f => !this.alreadySelectedFood.includes(f.id));
      } else {
        this.foods = result;
      }
    });
  }

  onSubmit() {
    // TODO Post entered data for task to api then (

    this.submitHandler.emit(this.selectedFood);
    // )
  }

  addFood(){
    this.patientService.addFood(
      {
        id: "00000000-0000-0000-0000-000000000000",
        name: this.name,
        calorieCount: this.calories,
        unit: this.unit,
        patientId: 1,
      }
    ).then(food => this.foods.push(food));
    this.name = '';
    this.calories = 0;
    this.unit = '';
  }

  onBack() {
    this.backHandler.emit();
  }
  toggleFood(food: IFood) {
    if (this.selectedFood.includes(food)) {
      this.selectedFood.splice(this.selectedFood.findIndex(fq => fq === food), 1);
    } else {
      this.selectedFood.push(food);
    }
  }
  removeFood(foodId: string) {
    const index = this.foods.findIndex(f => f.id === foodId);
    this.foods.splice(index, 1);

  }
}
