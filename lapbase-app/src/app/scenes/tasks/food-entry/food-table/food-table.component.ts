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
}
