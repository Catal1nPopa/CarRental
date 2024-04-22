import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetHybridService {

  private apiUrl = 'https://localhost:7032/api/GetCars/GetHybridCars';
  constructor(private http: HttpClient) { }

  getHybridCars(): Observable<HybridCar[]> {
    return this.http.get<HybridCar[]>(this.apiUrl);
  }
}

// electric-car.model.ts
export interface HybridCar {
  id: number;
  brand: string;
  distance: number;
  price: number;
  photo: string;
  model: string;
  year: number;
  enginePower: number;
  electricPower: number;
}