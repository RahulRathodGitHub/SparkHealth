export interface IExercise {
  id: string;

  name: string;
  calorieCount: number;
  unit: string;

  patientId: number;
}

export class Exercise {
  id: string;
  quantity: number;
}
