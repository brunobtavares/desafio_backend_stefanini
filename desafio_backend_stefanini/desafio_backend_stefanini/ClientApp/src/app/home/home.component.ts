import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  ngOnInit(): void {
    

    this.httpClient.get(this.baseUrl + 'weatherforecast').subscribe(r => console.log(r));
    this.httpClient.get(this.baseUrl + 'api/pessoa').subscribe(r => console.log(r));
  }

  /*

constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  ngOnInit(): void {
    let bff = this.baseUrl + 'weatherforecast';
    //let bff = this.baseUrl + 'pessoa';

    console.log(bff);

    this.http.get(bff).subscribe(result => {
      
    }, error => console.error(error));
  }

*/
}
