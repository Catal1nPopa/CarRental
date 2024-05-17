import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.development';
import { Client } from '../Models/Clients';

@Injectable({
  providedIn: 'root'
})
export class ClientsService {

  private apiUrl = environment.apiUrl + "FacadeVehicles/GetAllClients";
  private apiGetClient = environment.apiUrl + "FacadeVehicles/GetClient";

  constructor(private http: HttpClient) { }

  getAllClients(): Observable<any> {
    return this.http.get<Client>(this.apiUrl);
  }

  getClient(name: string): Observable<any> {
    const url = `${this.apiGetClient}?name=${name}`;
    return this.http.get<any>(url);
  }
}
