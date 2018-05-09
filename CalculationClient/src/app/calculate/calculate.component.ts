import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Calculation } from './calculation';
import { mememo } from './mememo';


@Component({
  selector: 'app-calculate',
  templateUrl: './calculate.component.html',
  styleUrls: ['./calculate.component.css']
})
export class CalculateComponent implements OnInit {

  model: any = {};
  data: any = {};
  submitted = false;

  constructor(private http: HttpClient) {
    
   }

  ngOnInit() {
  }

  onSubmit(form: any) {
    this.submitted = true;
    var model2 =  this.http.get<mememo>('http://calculateservice.azurewebsites.net/api/values/' + form)
    .subscribe(data =>{ 
      this.data = data;
      console.log(this.data);
    });
    ;
  }
}
