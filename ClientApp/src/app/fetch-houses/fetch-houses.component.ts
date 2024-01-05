import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-houses',
  templateUrl: './fetch-houses.component.html'
})
export class FetchHousesComponent {
  public houses: House[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<House[]>(baseUrl + 'house').subscribe(result => {
      this.houses = result;
    }, error => console.error(error));
  }
}

interface House {
  number: number;
  names: string;
  attributes: string;
  planets: string;
}
