import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-planets',
  templateUrl: './fetch-planets.component.html'
})
export class FetchPlanetsComponent {
  public planets: Planet[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Planet[]>(baseUrl + 'planet').subscribe(result => {
      this.planets = result;
    }, error => console.error(error));
  }
}

interface Planet {
  name: string;
  description: string;
  position: number;
  zodiacsigns: string;
}
