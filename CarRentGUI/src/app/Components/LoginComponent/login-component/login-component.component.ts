import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from '../../../Services/login.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-component',
  templateUrl: './login-component.component.html',
  styleUrl: './login-component.component.css'
})
export class LoginComponentComponent {

  loginForm!: FormGroup;

  constructor(private formBuilder: FormBuilder, private loginService: LoginService, private router: Router){}

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
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
              this.router.navigate(['home'])
            },
            error: (error) => {
              alert("Eroare la autentificare");
            }
          }
        );
      }
  }
}
