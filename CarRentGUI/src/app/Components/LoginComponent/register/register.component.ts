import { Component, OnInit } from '@angular/core';
import { RegisterService } from '../../../Services/register.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent implements OnInit {
  registerForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private registerService: RegisterService
  ) { }

  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  onSubmit(): void {
    if (this.registerForm.invalid) {
      return;
    }

    const username = this.registerForm.value.username;
    const password = this.registerForm.value.password;

    this.registerService.register(username, password)
      .subscribe(
        response => {
          console.log('Registration successful:', response);
          // Handle successful registration response
        },
        error => {
          console.error('Registration error:', error);
          // Handle error
        }
      );
  }

  goToLogin(){
    this.registerService.goToLogin();
  }
}