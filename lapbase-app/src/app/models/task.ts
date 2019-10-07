import { Meal } from './food';
import { Exercise } from './exercise';

export enum TaskType {
  FoodIntake,
  Exercise
}

export interface ITask {
  id: string;
  dueDate: Date;
  type: TaskType;
  completed: boolean;
  overdue: boolean;
  patientId: number;
  advisorId: number;
}

export class TaskInput {
  id: string;
  dateAssigned: Date;
  caloriesGained: number;
  caloriesLost:number;
  weight: number;
  meals: Meal[];
  exercises: Exercise[];
}
