import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DeleteService {

  private apiUrl = 'https://localhost:7032/api/DeleteCar/deleteCombustionCar';

  constructor(private http: HttpClient) { }

  deleteCar(carId: number): Observable<any> {
    const url = `${this.apiUrl}?carId=${carId}`;
    return this.http.delete(url);
  }
}
