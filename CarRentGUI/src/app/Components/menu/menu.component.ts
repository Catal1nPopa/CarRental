import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../../Services/login.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent implements OnInit {
  public userNameLabel: string = '';
  constructor(private router: Router, private loginService: LoginService) { }

  ngOnInit(): void {
    this.getName()
  }


  logout(){
    this.loginService.logOut();
  }

  getName() {
    const userName = this.loginService.getUserName();
    this.userNameLabel = userName;
  }

  getRole(){
    return this.loginService.getUserRole();
  }
  
}
