import { Component, OnInit, Output, EventEmitter } from "@angular/core";

@Component({
  selector: "app-food-choices",
  templateUrl: "./food-choices.component.html",
  styleUrls: ["./food-choices.component.scss"]
})
export class FoodChoicesComponent implements OnInit {
  @Output() submitFoodSelection = new EventEmitter();
  foodChoicesArray = [
    ["Roti", "Rice", "Halal Pork"],
    ["Habibi-Style Shwarma", "Meat platter", "Apple"],
    ["Mooncake", "HSP", "McD"]
  ];

  selectedFood: {
    name: string;
    quantity: number;
  }[] = [];

  constructor() {}

  ngOnInit() {}

  increaseQuantity(name) {
    if (this.selectedFood === null) {
      this.selectedFood.push({ name: name, quantity: 1 });
    } else {
      var index = this.findFood(name);
      if (index > -1) {
        this.selectedFood[index].quantity++;
      } else {
        this.selectedFood.push({ name: name, quantity: 1 });
      }
    }
    // loop: for (var i = 0; i < this.foodChoicesArray.length; i++) {
    //   for (var j = 0; j < this.foodChoicesArray[i].length; j++) {
    //     if (this.foodChoicesArray[i][j] === name) {
    //       console.log("increased");

    //       this.foodChoicesQuantity[i][j]++;
    //       break loop;
    //     }
    //   }
    // }
  }

  decreaseQuantity(name) {
    var index = this.findFood(name);

    if (this.selectedFood[index].quantity < 2) {
      this.selectedFood.splice(index, 1);
    } else {
      this.selectedFood[index].quantity--;
    }

    // loop: for (var i = 0; i < this.foodChoicesArray.length; i++) {
    //   for (var j = 0; j < this.foodChoicesArray[i].length; j++) {
    //     if (this.foodChoicesArray[i][j] === name) {
    //       console.log("decreased");
    //       this.foodChoicesQuantity[i][j]--;
    //       break loop;
    //     }
    //   }
    // }
  }

  findFood(foodName) {
    for (var i = 0; i < this.selectedFood.length; i++) {
      if (this.selectedFood[i].name == foodName) return i;
    }

    return -1;
  }

  save() {
    this.submitFoodSelection.emit(this.selectedFood);
  }
}
