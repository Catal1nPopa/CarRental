import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.development';
import { Client } from '../Models/Clients';
import { userData } from '../Models/UpdatePassword';

@Injectable({
  providedIn: 'root'
})
export class ClientsService {

  private apiUrl = environment.apiUrl + "FacadeVehicles/GetAllClients";
  private apiGetClient = environment.apiUrl + "FacadeVehicles/GetClient";
  private updateRole = environment.apiUrl + "Auth/SchimbareRol";
  constructor(private http: HttpClient) { }

  getAllClients(): Observable<any> {
    return this.http.get<Client>(this.apiUrl);
  }

  getClient(name: string): Observable<any> {
    const url = `${this.apiGetClient}?name=${name}`;
    return this.http.get<any>(url);
  }

  //https://localhost:7129/api/Auth/SchimbareRol

  changeRole(UpdateRole: { userName: string, RoleName: string }): Observable<any> {
    console.log(UpdateRole);
    console.log("service");
    return this.http.post<any>(this.updateRole, UpdateRole);
  }
}
