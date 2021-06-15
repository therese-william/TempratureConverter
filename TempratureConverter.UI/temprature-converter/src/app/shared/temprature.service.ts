import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Temprature } from './temprature.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class TempratureService {

  readonly apiUrl = environment.apiUrl;

  currentTemprature: Temprature = {
    celsius: undefined,
    fahrenheit: undefined,
    kelvin: undefined
  }

  constructor(private http: HttpClient) {
  }

  getTemprature(type: string) {
    var methodName: string = '';
    switch (type) {
      case 'c':
        if (this.currentTemprature.celsius) {
          methodName = '/GetTempratureByCelsius?celsius=' + this.currentTemprature.celsius;
        }
        break;
      case 'f':
        if (this.currentTemprature.fahrenheit) {
          methodName = '/GetTempratureByFahrenheit?fahrenheit=' + this.currentTemprature.fahrenheit;
        }
        break;
      case 'k':
        if (this.currentTemprature.kelvin) {
          methodName = '/GetTempratureByKelvin?kelvin=' + this.currentTemprature.kelvin;
        }
        break;
    }
    if (methodName != '') {
      this.http.get(this.apiUrl + methodName)
        .toPromise()
        .then(res => this.currentTemprature = res as Temprature);
    }
  }

  clearToRecalculate(type: string) {
    switch (type) {
      case 'c':
        this.currentTemprature.fahrenheit = undefined;
        this.currentTemprature.kelvin = undefined;
        break;
      case 'f':
        this.currentTemprature.celsius = undefined;
        this.currentTemprature.kelvin = undefined;
        break;
      case 'k':
        this.currentTemprature.fahrenheit = undefined;
        this.currentTemprature.celsius = undefined;
        break;
    }

  }
}
