import { Component, OnInit } from '@angular/core';
import { TaskInput, IFood, MealTime, Food } from 'src/app/models';
import { PatientService, TaskService } from 'src/app/services';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  date: Date;
  selectedMealTime: MealTime;
  totalCalories: number;
  availableFoodChoices: IFood[] = new Array<IFood>();
  taskInput: TaskInput = {
    id: '00000000-0000-0000-0000-000000000000',
    calories: 0,
    weight: 0,
    dateAssigned: new Date(),
    exercises: [],
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
  };
  isModalActive = false;
  breakfast: Food[];
  lunch: Food[];
  dinner: Food[];

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

  changeDate(forward: boolean) {
    if (forward) {
      this.date = new Date(this.date.setDate(this.date.getDate() + 1));
    } else {
      this.date = new Date(this.date.setDate(this.date.getDate() - 1));
    }
    this.taskService.getTaskByDate(this.date.toISOString()).then(taskInput => {
      this.taskInput = taskInput;
    });
  }

  changeQuantity = (mealTime: MealTime, foodId: string, increase: boolean) => {
    if (increase) {
      this.getMeal(mealTime).find(food => food.id === foodId).quantity++;
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
    this.taskInput.calories = totalCalories;
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

  getMeal = (mealTime: MealTime): Food[] => this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods;
  getFoodInfo = (foodId: string): IFood => this.availableFoodChoices.find(food => food.id === foodId);

  save = () => this.taskService.sendFoodIntake(this.taskInput).then(value => this.taskInput = value);
}
