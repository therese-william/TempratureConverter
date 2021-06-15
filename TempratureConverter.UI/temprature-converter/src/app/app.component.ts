import { Component } from '@angular/core';
import { TempratureService } from './shared/temprature.service';
import { Temprature } from './shared/temprature.model';
import { templateJitUrl } from '@angular/compiler';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Temprature Converter';
  constructor(public service: TempratureService) {
  }
}
