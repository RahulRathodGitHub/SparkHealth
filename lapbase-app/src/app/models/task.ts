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
