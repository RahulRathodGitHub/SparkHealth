export interface IReport {}

export class WeightReport implements IReport {
  weight: number[];
  weightRecordedTime: String[];
}

export enum reporttype {
  Weight
}
