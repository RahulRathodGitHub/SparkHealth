import { Component, OnInit, Input, EventEmitter, Output } from "@angular/core";

@Component({
  selector: "app-food-choice",
  templateUrl: "./food-choice.component.html",
  styleUrls: ["./food-choice.component.scss"]
})
export class FoodChoiceComponent implements OnInit {
  @Input() foodName: string;
  @Output() decreasedCount = new EventEmitter();
  @Output() increasedCount = new EventEmitter();
  count: number = 0;
  constructor() {}

  ngOnInit() {}

  increaseCount() {
    this.count++;
    this.increasedCount.emit(this.foodName);
  }

  decreaseCount() {
    this.count--;
    this.decreasedCount.emit(this.foodName);
  }
}
