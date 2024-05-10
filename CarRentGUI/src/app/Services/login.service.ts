import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable } from 'rxjs';
import { User } from '../Models/User';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private apiUrl = environment.apiUrl + "Auth/Login"
  private userData: any;

  constructor(private http: HttpClient, private router: Router)
  {
    this.userData = this.decodedToken();
  }

  Login(user: any){
    return this.http.post<any>(this.apiUrl, user);
  }


  decodedToken()
  {
    const jwt = new JwtHelperService();
    const token = this.getToken()!;
    console.log(jwt.decodeToken(token))
    return jwt.decodeToken(token)
  }

  getToken()
  {
    return localStorage.getItem('token');
  }

  isLogged() : boolean
  {
      return !!localStorage.getItem('token');
  }

  storeToken(token: string)
  {
      localStorage.setItem('token', token);
  }

  getUserIdFromToken(): number {
    const jwt = new JwtHelperService();
    const token = this.getToken();
    if (token) {
      const decodedToken: any = jwt.decodeToken(token);
      console.log(decodedToken.nameid);
      console.log("dasas");
      return decodedToken.nameid;
    }
    return 0;
  }
}
