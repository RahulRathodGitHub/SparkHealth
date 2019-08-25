export interface IReport {}

export class WeightReport implements IReport {
  weight: number[];
  weightRecordedTime: String[];
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
  ImperialFlag: Number;
  Weight: Number;
  CurrentWeight: Number;
  TargetWeight: Number;
  IdealWeight: Number;
  StartWeight: Number;
  HeightMeasurement: Number;
  WeightMeasurement: Number;
  visitWeeksFlag: Number;
  strZeroDate: String;
}

export enum reporttype {
  Weight,
  WeightLoss
}
