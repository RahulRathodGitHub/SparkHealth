import { Component, OnInit } from '@angular/core';
import { TaskInput, IFood, MealTime } from 'src/app/models';
import { PatientService, TaskService } from 'src/app/services';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  date: Date;
  selectedMealTime: MealTime;
  availableFoodChoices: IFood[];
  taskInput: TaskInput = {
    calories: 0,
    dateAssigned: new Date(),
    exercises: [],
    id: '',
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
      },
    ],
    weight: 0
  };
  isModalActive = false;

  ngOnInit() {
    this.patientService.getFoodList().then(foodChoiceList => {
      this.availableFoodChoices = foodChoiceList;
    });
    this.taskService.getTaskByDate(this.date.toISOString()).then(taskInput => {
      this.taskInput = taskInput;
    });
  }

  constructor(private taskService: TaskService, private patientService: PatientService) {
    this.date = new Date();
  }

  getMeal(mealTime: MealTime) {
    return this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods;
  }

  getFoodInfo(foodId: string) {
    return this.availableFoodChoices.find(food => food.id === foodId);
  }

  changeDate(forward: boolean) {
    if (forward) {
      this.date = new Date(this.date.setDate(this.date.getDate() + 1));
    } else {
      this.date = new Date(this.date.setDate(this.date.getDate() - 1));
    }
  }

  changeQuantity = (mealTime: MealTime, foodId: string, increase: boolean) => {
    if (increase) {
      this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods.find(food => food.id === foodId).quantity++;
    } else {
      const quantity = this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods.find(food => food.id === foodId).quantity;
      if (quantity < 2) {
        this.removeFood(mealTime, foodId);
      } else {
        this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods.find(food => food.id === foodId).quantity--;
      }
    }
  }

  removeFood(mealTime: MealTime, foodId: string) {
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

  toggleModal(mealTime: MealTime) {
    this.selectedMealTime = mealTime;
    this.isModalActive = !this.isModalActive;
  }

  modalClass() {
    if (this.isModalActive) {
      return 'modal is-active';
    }
    return 'modal';
  }

  save() {
    this.taskService.sendFoodIntake(this.taskInput);
  }
}
