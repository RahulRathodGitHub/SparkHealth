export interface ITask {
    id: string;
    dueDate: Date;
    type: number;
    completed: boolean;
    overdue: boolean;
    patientId: number;
    advisorId: number; 
}
