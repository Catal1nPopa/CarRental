import { Component } from '@angular/core';
import { LoginService } from '../../Services/login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  displayCarForm: boolean = false;

  constructor(private loginService: LoginService
  ){}

  logout(){
    this.loginService.logOut();
  }

showCarForm() {
  this.displayCarForm = !this.displayCarForm; 
   }

   getRolefromToken(){
    return this.loginService.getRolefromToken();
  }
}
