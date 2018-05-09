import { BrowserModule } from '@angular/platform-browser'
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'; 
import {FormsModule} from '@angular/forms';

import { routing }  from './app.routing';

import { AppComponent } from './app.component';
import { CalculateComponent } from './calculate/calculate.component';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    CalculateComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    routing,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
