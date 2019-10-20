import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";
import { IExercise, Exercise } from "src/app/models";

@Component({
  selector: "app-exercise-choices",
  templateUrl: "./exercise-choices.component.html",
  styleUrls: ["./exercise-choices.component.scss"]
})
export class ExerciseChoicesComponent implements OnInit {
  @Input() availableExerciseChoices: IExercise[];
  @Input() selectedExercises: Exercise[];
  @Input() totalCaloriesBurned: number;

  @Output() increaseCalorieBurned = new EventEmitter();
  @Output() decreaseCalorieBurned = new EventEmitter();

  constructor() {}

  ngOnInit() {}

  increaseQuantity(exerciseId: string, calorieCount: number) {
    if (this.selectedExercises === null) {
      this.selectedExercises.push({
        id: exerciseId,
        quantity: 1
      });
    } else {
      const index = this.findExerciseById(exerciseId);
      if (index > -1) {
        this.selectedExercises[index].quantity++;
      } else {
        this.selectedExercises.push({
          id: exerciseId,
          quantity: 1
        });
      }
    }
    this.totalCaloriesBurned += calorieCount;

    this.increaseCalorieBurned.emit(this.totalCaloriesBurned);
  }

  decreaseQuantity(exerciseId: string, calorieCount: number) {
    const index = this.findExerciseById(exerciseId);

    if (this.selectedExercises[index].quantity < 2) {
      this.selectedExercises.splice(index, 1);
    } else {
      this.selectedExercises[index].quantity--;
    }

    this.totalCaloriesBurned -= calorieCount;

    this.decreaseCalorieBurned.emit(this.totalCaloriesBurned);
  }

  getCount(exerciseChoiceId) {
    const index = this.findExerciseById(exerciseChoiceId);
    if (index > -1) {
      return this.selectedExercises[index].quantity;
    } else {
      return 0;
    }
  }

  findExerciseById(exerciseChoiceId: string) {
    return this.selectedExercises.findIndex(f => f.id === exerciseChoiceId);
  }
}
