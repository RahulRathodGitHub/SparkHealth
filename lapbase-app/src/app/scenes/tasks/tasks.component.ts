import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ITask, TaskType, TaskInput, IFood, Food, MealTime, Meal } from 'src/app/models';
import { PatientService } from 'src/app/services';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  private tasks: ITask[];
  selectedTaskId: string;
  selectedTaskType: TaskType;
  step: number;

  date: Date;
  yesterdayDate: Date;
  tomorrowDate: Date;

  selectedMealTime: MealTime;

  private availableFoodChoices: IFood[];
  taskInput: TaskInput = {
    id: 'db225c97-8515-4087-aeb9-f519cea4edea',
    dateAssigned: new Date(),
    calories: 0.0,
    weight: 0.0,
    meals: [
      {
        foods: [],
        mealTime: MealTime.BREAKFAST
      },
      {
        foods: [],
        mealTime: MealTime.LUNCH
      },
      {
        foods: [],
        mealTime: MealTime.DINNER
      }
    ],
    exercises: []
  };
  isModalActive = false;
  ngOnInit() {
    this.patientService.getFoodList().then(foodChoiceList => {
      this.availableFoodChoices = foodChoiceList;
    });

    // TODO Fill in date of task and make sure DTO matches
    // this.taskService.getTaskByDate(........).then(taskInput => {
    //   this.taskInput = taskInput;
    // });
  }

  constructor(
    private taskService: TaskService,
    private patientService: PatientService
  ) {
    this.step = 0;
    this.date = new Date();
  }

  getMeal(mealTime: MealTime) {
    return this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods;
  }

  getFoodInfo(foodId: string) {
    return this.availableFoodChoices.find(food => food.id === foodId);
  }

  onButtonClick(taskId: string) {
    this.selectedTaskId = taskId;
    this.selectedTaskType = this.tasks.find(t => t.id === taskId).type;
    this.step++;
  }

  next() {
    this.step++;
  }

  back() {
    this.step--;
    if (this.step === 0) {
      this.taskService.getTasks().then(result => (this.tasks = result));
    }
  }
  dateAfter() {
    this.tomorrowDate = new Date(this.date.setDate(this.date.getDate() + 1));
    this.date = this.tomorrowDate;
  }
  dateBefore() {
    this.yesterdayDate = new Date(this.date.setDate(this.date.getDate() - 1));
    this.date = this.yesterdayDate;
  }

  selectFood(mealtime: MealTime) {
    this.toggleModal();
    this.selectedMealTime = mealtime;
  }

  minusQuantity(foodId: string, mealTime: MealTime) {
    const quantity = this.taskInput.meals.find(meal => meal.mealTime === mealTime)
      .foods.find(food => food.id === foodId).quantity;
    if (quantity < 2) {
      this.removeFood(foodId, mealTime);
    } else {
      this.taskInput.meals.find(meal => meal.mealTime === mealTime)
        .foods.find(food => food.id === foodId).quantity--;
    }
  }

  addQuantity(foodId: string, mealTime: MealTime) {
    this.taskInput.meals.find(meal => meal.mealTime === mealTime)
      .foods.find(food => food.id === foodId).quantity++;
  }

  removeFood(foodId: string, mealTime: MealTime) {
    const index = this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods.findIndex(food => food.id === foodId);
    this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods.splice(index, 1);
  }

  calculateTotalCalories(): number {
    let totalCalories = 0;

    for (const meal of this.taskInput.meals) {
      for (const food of meal.foods) {
        totalCalories += food.quantity * this.getFoodInfo(food.id).calorieCount;
      }
    }

    return totalCalories;
  }

  toggleModal() {
    this.isModalActive = !this.isModalActive;
  }

  modalClass() {
    if (this.isModalActive) {
      return 'modal is-active';
    }
    return 'modal';
  }
}
