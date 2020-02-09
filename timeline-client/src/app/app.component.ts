import { Component } from '@angular/core';
//import { OktaAuthService } from '@okta/okta-angular';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'timeline-client';
  isAuthenticated: boolean;

  constructor() {
    this.isAuthenticated = true;
  }

  ngOnInit() {
  }

  login() {
  }

  logout() {

  }
}
