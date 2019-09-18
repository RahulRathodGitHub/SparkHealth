import { TaskService } from "./../../services/task.service";
import { Component, OnInit } from "@angular/core";
import { ITask, TaskType, TaskInput } from "src/app/models";
import { DatePipe } from "@angular/common";

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
  selectedFood = true;
  selectedMealTime: string;
  meals = {
    Breakfast: [],
    Lunch: [],
    Dinner: []
  };

  taskData: TaskInput;

  constructor(private taskService: TaskService) {
    taskService.getTasks().then(result => (this.tasks = result));
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
  ngOnInit() {
    console.log(this.selectedFood);
  }

  //Eric's method
  selectFood(mealtime) {
    this.selectedFood = false;
    this.selectedMealTime = mealtime;
  }

  getFoodSelection(foodSelection) {
    for (var i = 0; i < foodSelection.length; i++) {
      this.meals[this.selectedMealTime].push(foodSelection[i]);
    }
    this.selectedFood = true;
  }
}
