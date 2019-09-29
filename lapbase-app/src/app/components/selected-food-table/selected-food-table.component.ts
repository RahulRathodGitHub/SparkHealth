import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { MealTime, Meal, IFood, Food } from 'src/app/models';

@Component({
  selector: 'app-selected-food-table',
  templateUrl: './selected-food-table.component.html',
  styleUrls: ['./selected-food-table.component.scss']
})
export class SelectedFoodTableComponent implements OnInit {
  @Output() changeQuantity: EventEmitter<[MealTime, string, boolean]> = new EventEmitter();
  @Output() removeFood: EventEmitter<[MealTime, string]> = new EventEmitter();
  @Output() toggleModal: EventEmitter<MealTime> = new EventEmitter();

  @Input() getFoodInfo: (foodId: string) => IFood;
  @Input() mealName: string;
  @Input() mealTime: MealTime;
  @Input() selectedFood: Food[];

  constructor() { }

  ngOnInit() {
  }

  change = (foodId: string, increase: boolean): void => {
    this.changeQuantity.emit([this.mealTime, foodId, increase]);
  }
  remove = (foodId: string): void => {
    this.removeFood.emit([this.mealTime, foodId]);
  }
  toggle = (): void => {
    this.toggleModal.emit(this.mealTime);
  }
}
