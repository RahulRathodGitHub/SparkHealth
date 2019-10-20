import { Exercise } from "./../../models/exercise";
import { Component, OnInit } from "@angular/core";
import { TaskInput, IFood, MealTime, Food, IExercise } from "src/app/models";
import { PatientService, TaskService } from "src/app/services";

@Component({
  selector: "app-tasks",
  templateUrl: "./tasks.component.html",
  styleUrls: ["./tasks.component.scss"]
})
export class TasksComponent implements OnInit {
  foodFlag: boolean;
  foodActive: boolean;
  date: Date;
  selectedMealTime: MealTime;
  totalCalories: number;
  totalCaloriesBurned: number;
  availableFoodChoices: IFood[] = new Array<IFood>();
  availableExerciseChoices: IExercise[] = new Array<IExercise>();
  taskInput: TaskInput = {
    id: "00000000-0000-0000-0000-000000000000",
    caloriesGained: 0,
    caloriesLost: 0,
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
      }
    ]
  };
  isModalActive = false;
  isExerciseModalActive = false;
  breakfast: Food[];
  lunch: Food[];
  dinner: Food[];

  ngOnInit() {
    this.patientService.getFoodList().then(foodChoiceList => {
      this.availableFoodChoices = foodChoiceList;
    });
    this.patientService.getExerciseList().then(exerciseChoiceList => {
      this.availableExerciseChoices = exerciseChoiceList;
    });
    this.taskService.getTaskByDate(this.date.toISOString()).then(taskInput => {
      this.taskInput = taskInput;
      this.totalCalories = taskInput.caloriesGained;
      this.totalCaloriesBurned = taskInput.caloriesLost;
      console.log(this.taskInput);
      
    });
    this.foodActive = true;
    this.foodFlag = false;
  }

  constructor(
    private taskService: TaskService,
    private patientService: PatientService
  ) {
    this.date = new Date();
  }

  toggleExercises() {
    this.isExerciseModalActive = !this.isExerciseModalActive;
  }

  changeDate(forward: boolean) {
    //TODO: Uncomment the line below and experiment to make the save more robust
    //this.save();

    if (forward) {
      this.date = new Date(this.date.setDate(this.date.getDate() + 1));
    } else {
      this.date = new Date(this.date.setDate(this.date.getDate() - 1));
    }

    this.taskService.getTaskByDate(this.date.toISOString()).then(taskInput => {
      this.taskInput = taskInput;
      this.totalCalories = taskInput.caloriesGained;
      this.totalCaloriesBurned = taskInput.caloriesLost;
      console.log(this.taskInput);
      
    });
  }

  //#region Exercise Input
  changeReps = (exerciseId: string, increase: boolean) => {
    let exercise = this.taskInput.exercises.find(
      exercise => exercise.id === exerciseId
    );
    let calorieCount = this.getExerciseInfo(exercise.id).calorieCount;
    if (increase) {
      exercise.quantity++;
      this.totalCaloriesBurned += calorieCount;
    } else {
      const quantity = exercise.quantity;
      if (quantity < 2) {
        this.removeExercise(exerciseId);
      } else {
        this.totalCaloriesBurned -= calorieCount;
        exercise.quantity--;
      }
    }
  };

  removeExercise(exerciseId: string) {
    let exercises = this.taskInput.exercises;

    const index = exercises.findIndex(exercise => exercise.id === exerciseId);

    const quantity = exercises[index].quantity;
    const calorieCount = this.getExerciseInfo(exercises[index].id).calorieCount;
    this.totalCaloriesBurned -= quantity * calorieCount;
    this.taskInput.exercises.splice(index, 1);

    // this.calculateCaloriesBurned();
  }

  calculateCaloriesBurned() {
    let caloriesBurned = 0;
    for (const exercise of this.taskInput.exercises) {
      if (this.getExerciseInfo(exercise.id) != null)
        caloriesBurned +=
          exercise.quantity * this.getExerciseInfo(exercise.id).calorieCount;
    }
    //this.taskInput.calories -= caloriesBurned;
    this.totalCalories -= caloriesBurned;
    this.totalCaloriesBurned = caloriesBurned;
    this.taskInput.caloriesLost = caloriesBurned;
  }

  getExercises = (): Exercise[] => this.taskInput.exercises;

  getExerciseInfo = (exerciseId: string): IExercise =>
    this.availableExerciseChoices.find(exercise => exercise.id === exerciseId);
  //#endregion

  //#region FoodInput

  changeQuantity = (mealTime: MealTime, foodId: string, increase: boolean) => {
    var food;
    var calorieCount = this.getFoodInfo(foodId).calorieCount;
    if (increase) {
      food = this.getMeal(mealTime).find(food => food.id === foodId);
      this.totalCalories += calorieCount;
      food.quantity++;
    } else {
      food = this.taskInput.meals
        .find(meal => meal.mealTime === mealTime)
        .foods.find(food => food.id === foodId);

      const quantity = food.quantity;
      if (quantity < 2) {
        this.removeFood(mealTime, foodId);
      } else {
        this.totalCalories -= calorieCount;
        food.quantity--;
      }
    }
  };

  removeFood(mealTime: MealTime, foodId: string) {
    let foods = this.taskInput.meals.find(meal => meal.mealTime === mealTime)
      .foods;

    const index = foods.findIndex(food => food.id === foodId);

    let quantity = foods[index].quantity;
    let calorieCount = this.getFoodInfo(foods[index].id).calorieCount;

    this.totalCalories -= quantity * calorieCount;
    this.taskInput.caloriesGained = this.totalCalories;

    foods.splice(index, 1);
  }

  calculateCaloriesIntake() {
    let totalCalories = 0;
    for (const meal of this.taskInput.meals) {
      for (const food of meal.foods) {
        if (this.getFoodInfo(food.id) != null)
          totalCalories +=
            food.quantity * this.getFoodInfo(food.id).calorieCount;
      }
    }

    this.totalCalories = totalCalories;
    this.taskInput.caloriesGained = this.totalCalories;
  }

  updateCalories(newTotalCalories: number) {
    this.totalCalories = newTotalCalories;
    this.taskInput.caloriesGained = this.totalCalories;

  }

  updateCaloriesBurned(newTotalCaloriesBurned: number) {
    this.totalCaloriesBurned = newTotalCaloriesBurned;
    this.taskInput.caloriesLost = newTotalCaloriesBurned;
  }
  toggleModal(mealTime: MealTime) {
    this.selectedMealTime = mealTime;
    this.isModalActive = !this.isModalActive;
  }
  tooggleExercise() {
    this.isExerciseModalActive = !this.isExerciseModalActive;
  }

  modalClass() {
    if (this.isModalActive) {
      return "modal is-active";
    }
    return "modal";
  }
  exerciseModalClass() {
    if (this.isExerciseModalActive) {
      return "modal is-active";
    }
    return "modal";
  }
  changeFoodExercises() {
    this.foodFlag = !this.foodFlag;
    this.foodActive = !this.foodActive;
  }

  getMeal = (mealTime: MealTime): Food[] =>
    this.taskInput.meals.find(meal => meal.mealTime === mealTime).foods;
  getFoodInfo = (foodId: string): IFood =>
    this.availableFoodChoices.find(food => food.id === foodId);
  //#endregion

  save = () => {
    this.taskInput.caloriesLost = this.totalCaloriesBurned;
    this.taskInput.caloriesGained = this.totalCalories;
    console.log(this.taskInput);
    
    this.taskService.sendFoodIntake(this.taskInput).then(value => {
      this.taskInput = value;
      console.log(this.taskInput);
    });

   

    
    console.log(this.totalCalories);
  };

  canDeactivate() {
    this.save();
    return true;

    // return confirm("Your changes will be lost. Are you sure you want to leave without saving?");
  }
}
