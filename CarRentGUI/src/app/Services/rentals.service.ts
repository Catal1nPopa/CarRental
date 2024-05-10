import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RentModel } from '../Models/RentModel';

@Injectable({
  providedIn: 'root'
})
export class RentalsService {

  private apiUrl = environment.apiUrl + "Mediatr/GetRentals";
  private apiCreateRental = environment.apiUrl + "Mediatr/CreateRentalMediatr";
  constructor(private http: HttpClient) { }
  
  getAllRentals(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }

  createRental(dataRental: RentModel): Observable<any> {
    return this.http.post<any>(this.apiCreateRental, dataRental);
  }
}

