// To parse this data:
//
//   import { Convert, FinalReport } from "./file";
//
//   const finalReport = Convert.toFinalReport(json);

export interface FinalReport {
  Identifier: string;
  Name: string;
  AvailableRunways: number;
  Lat: number;
  Long: number;
  Temperature: number;
  RelativeHumidity: number;
  CloudCoverageSummary: string;
  VisibilityMiles: number;
  BestRunway: string;
  CurrentWindDirection: number;
  Forecast: Forecast[];
}

export interface Forecast {
  TimeOffset: string;
  WindSpeedMPH: number;
  WindDirection: number;
}

// Converts JSON strings to/from your types
export class Convert {
  public static toFinalReport(json: string): FinalReport {
    return JSON.parse(json);
  }

  public static finalReportToJson(value: FinalReport): string {
    return JSON.stringify(value);
  }
}
