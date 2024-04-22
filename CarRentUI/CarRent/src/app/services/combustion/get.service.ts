import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetService {

  private apiUrl = 'https://localhost:7032/api/GetCars/GetCombustionCars';
  constructor(private http: HttpClient) { }

  getCombustionCars(): Observable<CombustionCar[]> {
    return this.http.get<CombustionCar[]>(this.apiUrl);
  }
}

// electric-car.model.ts
export interface CombustionCar {
  id: number;
  brand: string;
  distance: number;
  price: number;
  photo: string;
  model: string;
  year: number;
  enginePower: number;
}
