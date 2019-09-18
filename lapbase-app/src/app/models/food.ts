export interface IFood {
  id: string;

  name: string;
  calorieCount: number;
  unit: string;

  patientId: number;
}

export class Food {
  name: string;
  quantity: string;
  mealTime: string;
}

export enum MealTime {
  BREAKFAST,
  LUNCH,
  DINNER
}
