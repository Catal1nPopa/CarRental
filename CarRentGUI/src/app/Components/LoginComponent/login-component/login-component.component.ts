import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from '../../../Services/login.service';
import { Router } from '@angular/router';
import { NgToastComponent, NgToastService } from 'ng-angular-popup';

@Component({
  selector: 'app-login-component',
  templateUrl: './login-component.component.html',
  styleUrl: './login-component.component.css'
})
export class LoginComponentComponent {

  loginForm!: FormGroup;

  constructor(private formBuilder: FormBuilder, private loginService: LoginService, private router: Router,
    private toast : NgToastService
  ){}

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  toggleForm(): void {
  }

  login()
  {
    if(this.loginForm.valid)
      {
        this.loginService.Login(this.loginForm.value).subscribe(
          {
            next: (res) => {
              this.loginService.storeToken(res.token)
              this.loginForm.reset()
              this.showSuccess()
              this.router.navigate(['home']);
            },
            error: (error) => {
              this.showError();
            }
          }
        );
      }
  }
  showError() {
    this.toast.error({detail:"ERROR",summary:'Eroare la autentificare',sticky:true});
  }
  showSuccess() {
    this.toast.success({detail:"SUCCESS",summary:'Autentificare cu succes',duration:5000});
  }
  showWarn() {
    this.toast.warning({detail:"WARN",summary:'Your Warn Message',duration:5000});
  }
  showInfo() {
    this.toast.info({detail:"INFO",summary:'Your Info Message',sticky:true});
  }
}
