import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DemoApp';
  response = "No data loaded, yet (maybe later)";
  constructor(private http: HttpClient)
  { 
    this.http.get('http://192.168.2.4:30663/demo', {responseType: 'text'}).subscribe((response: any) => {
      console.log(response);
	  this.response = response;		
	});
  }  
}