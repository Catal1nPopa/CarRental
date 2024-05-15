import { Component } from '@angular/core';
import { LoginService } from '../../Services/login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  constructor(private loginService: LoginService
  ){}

 
  ngOnInit(): void {
  
  }
  logout(){
    this.loginService.logOut();
  }

  getRolefromToken(){
    return this.loginService.getRolefromToken();
  }
}
