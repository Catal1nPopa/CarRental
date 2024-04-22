import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { FilterComponent } from './filter/filter.component';
import { CarBoxComponent } from './Car/car-box/car-box.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CarInsertComponent } from './Car/car-insert/car-insert.component';
import { ElectricCarComponent } from './electric/electric-car/electric-car.component';
import { CarElectricInsertComponent } from './electric/car-electric-insert/car-electric-insert.component';
import { GetHybridComponent } from './hybrid/get-hybrid/get-hybrid.component';
import { GetCombustionComponent } from './combustion/get-combustion/get-combustion.component';
import { InsertHybridComponent } from './hybrid/insert-hybrid/insert-hybrid.component';
import { InsertCombustionComponent } from './combustion/insert-combustion/insert-combustion.component';



@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    FilterComponent,
    CarBoxComponent,
    CarInsertComponent,
    ElectricCarComponent,
    CarElectricInsertComponent,
    GetHybridComponent,
    GetCombustionComponent,
    InsertHybridComponent,
    InsertCombustionComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
