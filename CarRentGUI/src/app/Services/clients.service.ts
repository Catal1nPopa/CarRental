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
  
  constructor(private http: HttpClient) { }

  getAllClients(): Observable<any> {
    return this.http.get<Client>(this.apiUrl);
  }
}
