import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponentComponent } from './Components/LoginComponent/login-component/login-component.component';
import { HomeComponent } from './Components/home/home.component';
import { authGuard } from './guards/auth.guard';
import { RegisterComponent } from './Components/LoginComponent/register/register.component';

const routes: Routes = [
  { path: '', component: LoginComponentComponent},
  { path: "login", component: LoginComponentComponent },
  { path: "register", component: RegisterComponent },
  { path: "home", component: HomeComponent, canActivate: [authGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
