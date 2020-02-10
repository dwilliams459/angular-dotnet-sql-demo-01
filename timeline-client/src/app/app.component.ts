import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'timeline-client';
  isAuthenticated: boolean;

  constructor(private httpClient: HttpClient) {
    this.isAuthenticated = true;
  }

  ngOnInit() {
  }

  login() {
  }

  logout() {

  }
}
