import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { RentModel } from '../Models/RentModel';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  private apiUrl = environment.apiUrl + "FacadeVehicles/GetAllVehicles";
  
  constructor(private http: HttpClient) { }

  getAllVehicles(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
