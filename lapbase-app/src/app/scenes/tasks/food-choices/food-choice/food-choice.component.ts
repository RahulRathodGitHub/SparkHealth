import { Component, OnInit, Input, EventEmitter, Output } from "@angular/core";
import { IFood } from "src/app/models";

@Component({
  selector: "app-food-choice",
  templateUrl: "./food-choice.component.html",
  styleUrls: ["./food-choice.component.scss"]
})
export class FoodChoiceComponent implements OnInit {
  @Input() foodChoice: IFood;
  @Output() decreasedCount = new EventEmitter();
  @Output() increasedCount = new EventEmitter();
  @Input() count: number;
  constructor() {}

  ngOnInit() {}

  increaseCount() {
    this.count++;
    this.increasedCount.emit(this.foodChoice);
  }

  decreaseCount() {
    this.count--;
    this.decreasedCount.emit(this.foodChoice);
  }
}
