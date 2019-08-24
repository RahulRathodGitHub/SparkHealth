export interface IReport {}

export class WeightReport implements IReport {
  weight: number[];
  weightRecordedTime: String[];
}

export class PatientProgressReport implements IReport {
  PatientID: String;
  PatientName: String;
  PatientTitle: String;
  FirstName: String;
  Surname: String;
  AGE: Number;
  dateseen: String;
  LapbandDate: String;
  StartEW: Number;
  WeightMeasurement: String;
  StartWeight: Number;
  IdealWeight: Number;
  BMIHeight: Number;
  Weight: Number;
  InitBMI: Number;
  BMI: Number;
  EWLL: Number;
  TWL: Number;
  ReportDate: Date;
}

export class EWLReport implements IReport {
  DateSeen: String;
  DateSeen_MY: String;
  strDateSeen: String;
  PatientId: Number;
  EWL: String;
  PatientName: String;
  InitBMI: Number;
  AGE: Number;
  strLapBandDate: String;
  Weight: Number;
  CurrentWeight: Number;
  TargetWeight: Number;
  IdealWeight: Number;
  StartWeight: Number;
  ImperialFlag: Number;
  HeightMeasurement: Number;
  WeightMeasurement: Number;
}

export enum reporttype {
  Weight
}
