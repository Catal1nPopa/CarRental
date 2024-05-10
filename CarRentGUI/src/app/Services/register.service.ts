import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { Route, Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  private registerUrl = environment.apiUrl + 'Auth/Register';
  
  constructor(private http: HttpClient, private router: Router) { }

  register(username: string, password: string, role: string = 'client'): Observable<any> {
    return this.http.post(this.registerUrl, { username, password, role });
  }
  
  goToLogin(){
    this.router.navigate(['login'])
  }
}
