import { Component, OnInit, Input, EventEmitter, Output } from "@angular/core";

@Component({
  selector: "app-food-choice",
  templateUrl: "./food-choice.component.html",
  styleUrls: ["./food-choice.component.scss"]
})
export class FoodChoiceComponent implements OnInit {
  @Input() foodChoice: string;
  @Output() decreasedCount = new EventEmitter();
  @Output() increasedCount = new EventEmitter();
  count: number = 0;
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
