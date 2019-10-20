import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";
import { IFood, Food } from "src/app/models";

@Component({
  selector: "app-food-choices",
  templateUrl: "./food-choices.component.html",
  styleUrls: ["./food-choices.component.scss"]
})
export class FoodChoicesComponent implements OnInit {
  @Input() availableFoodChoices: IFood[];
  @Input() selectedFoods: Food[];
  @Input() totalCalories: number;
  @Output() increaseCalorie = new EventEmitter();
  @Output() decreaseCalorie = new EventEmitter();

  constructor() {}

  ngOnInit() {}

  increaseQuantity(foodId: string, calorieCount: number) {
    if (this.selectedFoods === null) {
      this.selectedFoods.push({
        id: foodId,
        quantity: 1
      });
    } else {
      const index = this.findFoodById(foodId);
      if (index > -1) {
        this.selectedFoods[index].quantity++;
      } else {
        this.selectedFoods.push({
          id: foodId,
          quantity: 1
        });
      }
    }
    this.totalCalories += calorieCount;

    this.increaseCalorie.emit(this.totalCalories);
  }

  decreaseQuantity(foodId: string, calorieCount: number) {
    const index = this.findFoodById(foodId);

    if (this.selectedFoods[index].quantity < 2) {
      this.selectedFoods.splice(index, 1);
    } else {
      this.selectedFoods[index].quantity--;
    }
    this.totalCalories -= calorieCount;

    this.decreaseCalorie.emit(this.totalCalories);
  }

  getCount(foodChoiceId) {
    const index = this.findFoodById(foodChoiceId);
    if (index > -1) {
      return this.selectedFoods[index].quantity;
    } else {
      return 0;
    }
  }

  findFoodById(foodChoiceId: string) {
    return this.selectedFoods.findIndex(f => f.id === foodChoiceId);
  }
}
