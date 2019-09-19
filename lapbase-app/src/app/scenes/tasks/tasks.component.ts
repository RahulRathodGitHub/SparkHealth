import { TaskService } from "./../../services/task.service";
import { Component, OnInit } from "@angular/core";
import { ITask, TaskType, TaskInput } from "src/app/models";
import { DatePipe } from "@angular/common";
import { PatientService } from "src/app/services";

@Component({
  selector: "app-tasks",
  templateUrl: "./tasks.component.html",
  styleUrls: ["./tasks.component.scss"]
})
export class TasksComponent implements OnInit {
  private tasks: ITask[];
  selectedTaskId: string;
  selectedTaskType: TaskType;
  step: number;

  date: Date;
  yesterdayDate: Date;
  tomorrowDate: Date;

  //Eric's addition
  hasSelectedFood = true;
  selectedMealTime: string;
  selectedMeals = {
    breakfast: [],
    lunch: [],
    dinner: []
  };

  iFoodChoicesArray = [];

  ngOnInit() {
    this.patientService.getFoodList().then(foodList => {
      // console.log(foodList);

      let foodLeft = foodList.length;
      let tempArray = [];
      var i = -1;
      while (foodLeft > 3) {
        tempArray = [];
        foodLeft -= 3;

        for (var j = 0; j < 3; j++) {
          tempArray.push(foodList[++i]);
        }
        this.iFoodChoicesArray.push(tempArray);
      }

      tempArray = [];
      while (foodLeft > 0) {
        tempArray.push(foodList[++i]);
        foodLeft--;
      }
      this.iFoodChoicesArray.push(tempArray);
    });

    // //Getting Food list and sorting them into array with rows of 3
    // this.foodList = this.patientService.getFoodList();
    // let foodLeft = this.foodList.length;
    // let tempArray = [];
    // var i = -1;
    // while (foodLeft > 3) {
    //   tempArray = [];
    //   foodLeft -= 3;

    //   for (var j = 0; j < 3; j++) {
    //     tempArray.push(this.foodList[++i]);
    //   }
    //   this.foodChoicesArray.push(tempArray);
    // }

    // tempArray = [];
    // while (foodLeft > 0) {
    //   tempArray.push(this.foodList[++i]);
    //   foodLeft--;
    // }
    // this.foodChoicesArray.push(tempArray);
  }

  taskData: TaskInput;

  constructor(
    private taskService: TaskService,
    private patientService: PatientService
  ) {
    // taskService.getTasks().then(result => (this.tasks = result));
    this.step = 0;
    this.date = new Date();
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

  //Eric's method
  selectFood(mealtime) {
    this.hasSelectedFood = false;
    this.selectedMealTime = mealtime;
  }

  getFoodSelection(foodSelection) {
    // for (var i = 0; i < foodSelection.length; i++) {
    //   this.selectedMeals[this.selectedMealTime].push(foodSelection[i]);
    // }
    console.log(this.selectedMeals[this.selectedMealTime]);

    this.hasSelectedFood = true;
  }
  findIndexOfFood(foodId: string, mealTime) {
    return this.selectedMeals[mealTime].findIndex(f => f.id == foodId);
  }

  minusQuantity(foodId: string, mealTime) {
    let quantity = this.selectedMeals[mealTime][
      this.findIndexOfFood(foodId, mealTime)
    ].quantity;
    if (quantity < 2) {
      this.removeFood(foodId, mealTime);
    } else {
      this.selectedMeals[mealTime][this.findIndexOfFood(foodId, mealTime)]
        .quantity--;
    }
  }

  addQuantity(foodId: string, mealTime) {
    this.selectedMeals[mealTime][this.findIndexOfFood(foodId, mealTime)]
      .quantity++;
  }

  removeFood(foodId: string, mealTime) {
    this.selectedMeals[mealTime].splice(
      this.findIndexOfFood(foodId, mealTime),
      1
    );
  }
  calculateTotalCalories(): number {
    let totalCalories = 0;

    for (let food of this.selectedMeals.breakfast) {
      totalCalories += food.quantity * food.calorieCount;
    }

    for (let food of this.selectedMeals.lunch) {
      totalCalories += food.quantity * food.calorieCount;
    }

    for (let food of this.selectedMeals.dinner) {
      totalCalories += food.quantity * food.calorieCount;
    }

    return totalCalories;
  }
}
