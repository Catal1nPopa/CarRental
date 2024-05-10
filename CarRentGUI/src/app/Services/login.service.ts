import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable } from 'rxjs';
import { User } from '../Models/User';
import { NgToastService } from 'ng-angular-popup';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  private registerUrl = environment.apiUrl + 'Auth/Register';
  private apiUrl = environment.apiUrl + "Auth/Login"
  private userData: any;

  constructor(private http: HttpClient, private router: Router,private toast : NgToastService)
  {
    this.userData = this.decodedToken();
  }

  register(username: string, password: string, role: string = 'client'): Observable<any> {
    return this.http.post(this.registerUrl, { username, password, role });
  }

  Login(user: any){
    return this.http.post<any>(this.apiUrl, user);
  }

  showInfo() {
    this.toast.info({detail:"LogOut",summary:'Va-ti delogat cu succes',sticky:true});
  }
  decodedToken()
  {
    const jwt = new JwtHelperService();
    const token = this.getToken()!;
    console.log(jwt.decodeToken(token))
    return jwt.decodeToken(token)
  }

  goToRegister(){
    this.router.navigate(['register'])
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

  logOut(){
    this.showInfo();
    localStorage.clear();
    this.router.navigate(['login'])
  }

  getNameFroToken(){
    if(this.userData)
      return this.userData.unique_name;
  }

  getRolefromToken(){
    if(this.userData)
      return this.userData.role;
  }
}
