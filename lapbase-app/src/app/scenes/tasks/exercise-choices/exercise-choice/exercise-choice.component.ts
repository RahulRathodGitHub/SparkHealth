import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { IExercise } from 'src/app/models';

@Component({
  selector: 'app-exercise-choice',
  templateUrl: './exercise-choice.component.html',
  styleUrls: ['./exercise-choice.component.scss']
})
export class ExerciseChoiceComponent implements OnInit {
  @Output() decreasedCount = new EventEmitter();
  @Output() increasedCount = new EventEmitter();
  @Input() exerciseChoice: IExercise;
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

