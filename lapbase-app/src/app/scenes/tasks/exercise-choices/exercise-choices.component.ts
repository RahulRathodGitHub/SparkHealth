import { Component, OnInit, Input } from '@angular/core';
import { IExercise, Exercise } from 'src/app/models';

@Component({
  selector: 'app-exercise-choices',
  templateUrl: './exercise-choices.component.html',
  styleUrls: ['./exercise-choices.component.scss']
})
export class ExerciseChoicesComponent implements OnInit {
  @Input() availableExerciseChoices: IExercise[];
  @Input() selectedExercises: Exercise[];

  constructor() {
  }

  ngOnInit() {
  }

  increaseQuantity(exerciseId: string) {
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
  }

  decreaseQuantity(exerciseId: string) {
    const index = this.findExerciseById(exerciseId);

    if (this.selectedExercises[index].quantity < 2) {
      this.selectedExercises.splice(index, 1);
    } else {
      this.selectedExercises[index].quantity--;
    }
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
