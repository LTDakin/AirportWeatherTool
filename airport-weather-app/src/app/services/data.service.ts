import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private baseUrl = 'http://localhost:5236/AirportWeather';
  private testUrl = 'http://localhost:5236/AirportWeather?airportID=KDAB';

  constructor(private http: HttpClient) { }

  getData(airportID: string){
    var url :string = `${this.baseUrl}?airportID=${airportID}`;
    return this.http.get(url);
  }
}
