import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../../Car/car-box/car-box.component';
@Injectable({
  providedIn: 'root'
})
export class GetCarsService {

  private apiUrl = 'https://localhost:7032/api/GetCars/Getcars2'; // Aici specifici URL-ul API-ului tău C#

  constructor(private http: HttpClient) { }

  getCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.apiUrl);
  }
}
