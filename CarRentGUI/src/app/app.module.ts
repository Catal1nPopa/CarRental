import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponentComponent } from './Components/LoginComponent/login-component/login-component.component';
import { HttpClientModule, provideHttpClient, withFetch, withInterceptors } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { tokenInterceptor } from './interceptors/token.interceptor';
import { HomeComponent } from './Components/home/home.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { VehicleListComponent } from './Components/vehicle-list/vehicle-list.component';
import { RentalListComponent } from './Components/rental-list/rental-list.component'; 

@NgModule({
  declarations: [
    AppComponent,
    LoginComponentComponent,
    HomeComponent,
    VehicleListComponent,
    RentalListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgbModule,
    FormsModule
  ],
  providers: [
    provideHttpClient(withFetch(), withInterceptors([tokenInterceptor])),
    provideClientHydration(),
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
