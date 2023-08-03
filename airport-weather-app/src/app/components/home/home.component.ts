import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  // data fields
  airportName: string = '';
  myData : any;
  airports: string[] = [];

  constructor(private dataService: DataService) {}

  ngOnInit(): void{
    this.dataService.getData().subscribe((data) => {
      this.myData = data;
      console.log(this.myData);
    })
  }
  
  // add airport to the list of airports and clear the input box for the next name
  public addAirport(){
    console.log("hello world");
  }
}
