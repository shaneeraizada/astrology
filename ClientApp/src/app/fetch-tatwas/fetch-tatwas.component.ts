import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-tatwas',
  templateUrl: './fetch-tatwas.component.html'
})
export class FetchTatwasComponent {
  public tatwas: Tatwa[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Tatwa[]>(baseUrl + 'tatwa').subscribe(result => {
      this.tatwas = result;
    }, error => console.error(error));
  }
}

interface Tatwa {
  name: string;
  element: string;
  attributes: string;
  rulingplanets: string;
  duration: string;
  dayswhenfirst: string[];
}
