import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { NgxTimelineModule } from 'ngx-timeline';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ModalModule } from 'ngx-bootstrap/modal';
import { HomeComponent } from './home/home.component';
import { TimelineComponent } from './timeline/timeline.component';

//import { OktaAuthModule } from '@okta/okta-angular';
import { PartlistComponent } from './partlist/partlist.component';
import { PartComponent } from './part/part.component';

@NgModule({
   declarations: [
      AppComponent,
      HomeComponent,
      TimelineComponent,
      PartlistComponent,
      PartComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      AppRoutingModule,
      BrowserAnimationsModule,
      FormsModule,
      ReactiveFormsModule,
      BsDatepickerModule.forRoot(),
      NgxTimelineModule,
      ModalModule.forRoot()
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }