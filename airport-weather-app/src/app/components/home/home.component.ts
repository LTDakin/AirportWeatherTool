import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/services/data.service';
import { Convert, FinalReport } from 'src/app/models/Report';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  // data fields
  airportID: string = '';
  myData: FinalReport | undefined;
  airports: string[] = [];

  constructor(private dataService: DataService) {}

  // add airport to the list of airports and clear the input box for the next name
  public addAirport() {
    this.dataService.getData(this.airportID).subscribe((data) => {
      this.myData = data as FinalReport;
      console.log(this.myData.Forecast);
    });
  }
}
