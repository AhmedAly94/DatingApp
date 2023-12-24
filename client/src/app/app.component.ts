import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit{
  title = 'Hello Mariam & Ahmed welcome to the website world!';
  users: any;
  constructor(private http:HttpClient){}

  ///Make HTTP request from angular to API server
  ngOnInit(): void {
    //observable:stream of data
    this.http.get('http://localhost:5001/api/users').subscribe({
      next: response => this.users = response,
      error: error => console.log(error),
      complete: () => console.log('Request has completed')
    })
  }
}
