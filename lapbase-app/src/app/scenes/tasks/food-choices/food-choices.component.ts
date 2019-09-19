import { Component, OnInit, Output, EventEmitter, Input } from "@angular/core";

@Component({
  selector: "app-food-choices",
  templateUrl: "./food-choices.component.html",
  styleUrls: ["./food-choices.component.scss"]
})
export class FoodChoicesComponent implements OnInit {
  @Output() submitFoodSelection = new EventEmitter();
  @Input() iFoodChoicesSelections: [];
  @Input() selectedFoods;

  // foodChoicesArray = [
  //   // ["Roti", "Rice", "Halal Pork"],
  //   // ["Habibi-Style Shwarma", "Meat platter", "Apple"],
  //   // ["Mooncake", "HSP", "McD"]
  // ];

  constructor() {}

  ngOnInit() {
    // console.log(this.selectedFoods);
  }

  increaseQuantity(foodChoice) {
    if (this.selectedFoods === null) {
      this.selectedFoods.push({
        id: foodChoice.id,
        name: foodChoice.name,
        calorieCount: foodChoice.calorieCount,
        quantity: 1
      });
    } else {
      var index = this.findFood(foodChoice.name);
      if (index > -1) {
        this.selectedFoods[index].quantity++;
      } else {
        this.selectedFoods.push({
          id: foodChoice.id,
          name: foodChoice.name,
          calorieCount: foodChoice.calorieCount,
          quantity: 1
        });
      }
    }
  }

  decreaseQuantity(foodChoice) {
    var index = this.findFood(foodChoice.name);

    if (this.selectedFoods[index].quantity < 2) {
      this.selectedFoods.splice(index, 1);
    } else {
      this.selectedFoods[index].quantity--;
    }
  }

  getCount(foodChoiceName) {
    var index = this.findFood(foodChoiceName);
    if (index > -1) {
      return this.selectedFoods[index].quantity;
    } else {
      return 0;
    }
  }

  findFood(foodChoiceName) {
    return this.selectedFoods.findIndex(f => f.name == foodChoiceName);
  }

  save() {
    this.submitFoodSelection.emit(this.selectedFoods);
  }
}
