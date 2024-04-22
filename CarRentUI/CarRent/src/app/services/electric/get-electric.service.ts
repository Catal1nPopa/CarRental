import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetElectricService {

  private apiUrl = 'https://localhost:7032/api/GetCars/GetElectricCars';
  constructor(private http: HttpClient) { }

  getElectricCars(): Observable<ElectricCar[]> {
    return this.http.get<ElectricCar[]>(this.apiUrl);
  }
}

// electric-car.model.ts
export interface ElectricCar {
  id: number;
  brand: string;
  distance: number;
  price: number;
  photo: string;
  model: string;
  year: number;
  batteryCapacity: number;
  electricPower: number;
}
