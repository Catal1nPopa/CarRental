import { Component, OnInit } from '@angular/core';
import { RegisterService } from '../../../Services/register.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgToastModule, NgToastService } from 'ng-angular-popup';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent implements OnInit {
  registerForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private registerService: RegisterService,
    private toast: NgToastService
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
          this.showSuccessRegister();
        },
        error => {
          this.showErrorRegister();
        }
      );
  }

  showErrorRegister() {
    this.toast.error({detail:"ERROR",summary:'Eroare la inregistrare',sticky:true});
  }
  showSuccessRegister() {
    this.toast.success({detail:"SUCCESS",summary:'Inregistrare cu succes',duration:5000});
  }
}