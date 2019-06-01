export interface ITask {
    Id: string;
    // StartDate: Date;
    // Repetition: ;
    // RepetitionInterval: ;
    // Type: ;
    // PatientId: ;
    // AdvisorId: ;
    title: string;
    description: string;
    dueDate: Date;
    isCompleted: boolean;
    whenCreated: Date;
}
