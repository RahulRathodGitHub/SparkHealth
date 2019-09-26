export interface IFood {
  id: string;
  name: string;
  calorieCount: number;
  unit: string;
}

export class Food {
  id: string;
  quantity: number;
}

export class Meal {
  foods: Food[];
  mealTime: MealTime;
}

export enum MealTime {
  BREAKFAST,
  LUNCH,
  DINNER
}
