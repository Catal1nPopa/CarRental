import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DeleteCarsService {

  private apiUrl = 'https://localhost:7032/api/DeleteCar/deleteCar';

  constructor(private http: HttpClient) { }

  deleteCar(carId: number): Observable<any> {
    const url = `${this.apiUrl}?carId=${carId}`;
    return this.http.delete(url);
  }
}
