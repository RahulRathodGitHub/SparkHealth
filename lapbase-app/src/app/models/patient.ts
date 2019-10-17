
export interface IPatient {
    id: number;

    userName: string;
    whenCreated: Date;
    validFrom: Date;
    validTo: Date;
    deleted: boolean;
    advisorId: number;
}


export class Patient{

    surname: string;
    firstName: string;
    title: number;
    street: string;
    suburb: string;
    state: string;
    postcode: number;
    homePhone: number;
    workPhone: number;
    mobilePhone: number;
    emailAddress: string;
    birthDate: Date;
    sex: string;
    race: string

}