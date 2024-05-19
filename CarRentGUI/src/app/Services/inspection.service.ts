import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Inspection } from '../Models/Inspection';

@Injectable({
  providedIn: 'root'
})
export class InspectionService {

  private apigetInspections = environment.apiUrl + "VehicleInspection/GetInspections";
  private createInspection = environment.apiUrl + "VehicleInspection/CreateInspection";
  constructor(private http: HttpClient) { }
  
  getAllInspections(): Observable<any> {
    return this.http.get<any>(this.apigetInspections);
  }

  createInspect(insepctionData: Inspection): Observable<any> {
    return this.http.post<any>(this.createInspection, insepctionData);
  }
}
