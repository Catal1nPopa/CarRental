import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RentModel, Rental } from '../Models/RentModel';

@Injectable({
  providedIn: 'root'
})
export class RentalsService {

  private apiUrl = environment.apiUrl + "Mediatr/GetRentals";
  private apiCreateRental = environment.apiUrl + "Mediatr/CreateRentalMediatr";
  private deleteRental = environment.apiUrl + "FacadeVehicles/DeleteRental";
  private getRentalsByCustomer = environment.apiUrl + "FacadeVehicles/GetRentalsCustomer";
  constructor(private http: HttpClient) { }
  
  getAllRentals(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }

  createRental(dataRental: RentModel): Observable<any> {
    return this.http.post<any>(this.apiCreateRental, dataRental);
  }

  deleteRentalById(id: number): Observable<any> {
    return this.http.post(this.deleteRental, id);
  }  
  deleteRentals(id: number): Observable<any> {
    const url = `${this.deleteRental}/?id=${id}`;
    return this.http.delete(url);
  }

  getRentalsCustomer(id: number): Observable<Rental[]> {
    const url = `${this.getRentalsByCustomer}?id=${id}`;
    return this.http.get<Rental[]>(url);
  }
}

