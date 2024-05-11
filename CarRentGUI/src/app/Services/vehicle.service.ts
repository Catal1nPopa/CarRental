import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { RentModel } from '../Models/RentModel';
import { Vehicle } from '../Models/Vehicle';
import { UpdateVehicleStatus } from '../Models/UpdateVehicleStatus';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  private apiUrl = environment.apiUrl + "FacadeVehicles/GetAllVehicles";
  
  constructor(private http: HttpClient) { }

  getAllVehicles(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }

  private deleteVehicleUrl = environment.apiUrl + "FacadeVehicles/DeleteVehicle";

  deleteVehicle(id: number, type: string): Observable<any> {
    const url = `${this.deleteVehicleUrl}/?id=${id}&type=${type}`;
    return this.http.delete(url);
  }

  private addVehicleUrl = environment.apiUrl +"FacadeVehicles/AddVehicle";

  createCar(carData: Vehicle): Observable<any> {
    return this.http.post<any>(this.addVehicleUrl, carData);
  }

  private updateStatus = environment.apiUrl + "Mediatr/UpdateStatus";

  updateVehicleStatus(UpdateVehicleStatus: UpdateVehicleStatus): Observable<any>{
    // Trimiteți datele în corpul cererii HTTP
    return this.http.patch<any>(environment.apiUrl + "Mediatr/UpdateStatus", UpdateVehicleStatus);
  }
  
}
