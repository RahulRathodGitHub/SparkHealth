export interface IAppointment {
    id: string;
    title: string;
    start: Date;
    end: Date;
    patientId: number;
    description: string;
    doctorName: string;
    location: string;
    weight: number;
    bmi: number;
}
