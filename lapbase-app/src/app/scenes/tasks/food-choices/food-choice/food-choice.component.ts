import { Component, OnInit, Input, EventEmitter, Output } from "@angular/core";
import { IFood } from "src/app/models";

@Component({
  selector: "app-food-choice",
  templateUrl: "./food-choice.component.html",
  styleUrls: ["./food-choice.component.scss"]
})
export class FoodChoiceComponent implements OnInit {
  @Output() decreasedCount = new EventEmitter();
  @Output() increasedCount = new EventEmitter();
  @Input() foodChoice: IFood;
  @Input() count: number;
  constructor() {}

  ngOnInit() {}

  increaseCount() {
    this.increasedCount.emit();
  }

  decreaseCount() {
    this.decreasedCount.emit();
  }
}
