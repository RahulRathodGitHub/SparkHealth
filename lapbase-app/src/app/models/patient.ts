
export interface IPatient {
    id: number;

    userName: string;
    whenCreated: Date;
    validFrom: Date;
    validTo: Date;
    deleted: boolean;
    advisorId: number;
}
