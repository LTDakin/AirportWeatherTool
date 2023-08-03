import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // data fields
  airportName: string = '';
  title: string = 'airport-weather-app';
  airports: string[] = [];

  // add airport to the list of airports and clear the input box for the next name
  public addAirport(){
    this.airports.unshift(this.airportName);
    this.airportName = '';
  }
}
