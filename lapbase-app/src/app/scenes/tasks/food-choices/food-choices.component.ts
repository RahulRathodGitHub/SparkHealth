import { Component, OnInit, Input } from '@angular/core';
import { IFood, Food } from 'src/app/models';

@Component({
  selector: 'app-food-choices',
  templateUrl: './food-choices.component.html',
  styleUrls: ['./food-choices.component.scss']
})
export class FoodChoicesComponent implements OnInit {
  @Input() availableFoodChoices: IFood[];
  @Input() selectedFoods: Food[];

  constructor() {}

  ngOnInit() {
  }

  increaseQuantity(foodId: string) {
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
  }

  decreaseQuantity(foodId: string) {
    const index = this.findFoodById(foodId);

    if (this.selectedFoods[index].quantity < 2) {
      this.selectedFoods.splice(index, 1);
    } else {
      this.selectedFoods[index].quantity--;
    }
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
