export interface IFoodIntakeListDto {
    id: string;
    food: string;
    quantity: string;
    weight: number;
    calories: number;
    taskId: string;
    dateEntered: Date;
}
