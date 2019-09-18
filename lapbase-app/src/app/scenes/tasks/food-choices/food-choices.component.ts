import { Component, OnInit, Output, EventEmitter, Input } from "@angular/core";
import { IFood } from "src/app/models";

@Component({
  selector: "app-food-choices",
  templateUrl: "./food-choices.component.html",
  styleUrls: ["./food-choices.component.scss"]
})
export class FoodChoicesComponent implements OnInit {
  @Output() submitFoodSelection = new EventEmitter();
  @Input() foodChoicesSelection: [];

  // foodChoicesArray = [
  //   // ["Roti", "Rice", "Halal Pork"],
  //   // ["Habibi-Style Shwarma", "Meat platter", "Apple"],
  //   // ["Mooncake", "HSP", "McD"]
  // ];

  selectedFood = [];

  constructor() {}

  ngOnInit() {}

  increaseQuantity(foodChoice) {
    if (this.selectedFood === null) {
      this.selectedFood.push({ food: foodChoice, quantity: 1 });
    } else {
      var index = this.findFood(foodChoice.name);
      if (index > -1) {
        this.selectedFood[index].quantity++;
      } else {
        this.selectedFood.push({ food: foodChoice, quantity: 1 });
      }
    }
  }

  decreaseQuantity(foodChoice) {
    var index = this.findFood(foodChoice.name);

    if (this.selectedFood[index].quantity < 2) {
      this.selectedFood.splice(index, 1);
    } else {
      this.selectedFood[index].quantity--;
    }
  }

  findFood(foodChoiceName) {
    for (var i = 0; i < this.selectedFood.length; i++) {
      if (this.selectedFood[i].food.name == foodChoiceName) return i;
    }

    return -1;
  }

  save() {
    this.submitFoodSelection.emit(this.selectedFood);
  }
}
