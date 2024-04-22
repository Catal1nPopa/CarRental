import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InsertService {

  private apiUrl = 'https://localhost:7032/api/InsertCars/InsertCombustion';

  constructor(private http: HttpClient) { }

  insertCar(carData: any): Observable<any> {
    delete carData.id;
    return this.http.post<any>(this.apiUrl, carData);
  }
}
