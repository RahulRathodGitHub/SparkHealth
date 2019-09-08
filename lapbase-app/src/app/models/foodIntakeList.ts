import { IFood, ITask } from 'src/app/models';


export interface IFoodIntakeList {
    id: string;
    food: IFood[];
    quantity: number[];
    weight: number;
    calories: number;
    taskId: string;
    dateEntered: Date;
}
