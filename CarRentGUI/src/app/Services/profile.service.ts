import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError } from 'rxjs';
import { UpdatePhone } from '../Models/UpdatePhone';
import { User } from '../Models/User';
import { userData } from '../Models/UpdatePassword';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {

  private apiUpdatePhone = environment.apiUrl + "FacadeVehicles/UpdatePhone";
  private apiUpdatePassword = environment.apiUrl + "Auth/SchimbareParola";
  
  constructor(private http: HttpClient) { }

  changePhone(dataProfile: UpdatePhone): Observable<string>{
    return this.http.patch(`${this.apiUpdatePhone}`, dataProfile, { responseType: 'text' })
      .pipe();
  }

  changePassword(user: userData){
    console.log(user);
    console.log("as");
    return this.http.post<any>(this.apiUpdatePassword, user);
  }
}
