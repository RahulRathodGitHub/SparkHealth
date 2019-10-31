
export interface IPatient {
    id: number;
    userName: string;
    whenCreated: Date;
    validFrom: Date;
    validTo: Date;
    deleted: boolean;
    advisorId: number;
}

export class Patient {
    surname: string;
    firstname: string;
    title: string;
    street: string;
    suburb: string;
    state: string;
    postcode: string;
    homePhone: string;
    workPhone: string;
    mobilePhone: string;
    emailAddress: string;
    birthdate: Date;
    sex: string;
    race: string;
    insurance: string;
    dateFirstVisit: Date;
    dateLastVisit: Date;
    maritalStatus: string;
    medicalSummary: string;
    doctorName: string;
    doctorTelephone: string;
    doctorFax: string;
    lapBandDate: Date;
    notes: string;
    height: number;
    startWeight: number;
    startWeightDate: Date;
    idealWeight: number;
    currentWeight: number;
    opWeight: number;
    targetWeight: number;
    surgeryType: string;
    approach: string;
    startBmiweight: number;
    visitWeeksFlag: number;
    lapbandType: string;
    lapbandSize: string;
}
