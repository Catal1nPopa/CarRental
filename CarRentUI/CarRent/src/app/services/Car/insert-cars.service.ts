import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InsertCarsService {

  private apiUrl = 'https://localhost:7032/api/InsertCars/InsertCar';

  constructor(private http: HttpClient) { }

  insertCar(carData: any): Observable<any> {
    delete carData.id;
    return this.http.post<any>(this.apiUrl, carData);
  }
}
