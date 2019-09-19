export interface IExercise {
  id: string;

  name: string;
  calorieCount: number;
  unit: string;

  patientId: number;
}

export class Exercise {
  name: string;
  quantity: string;
}
