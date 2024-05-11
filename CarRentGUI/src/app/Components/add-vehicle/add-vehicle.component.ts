import { Component, OnInit } from '@angular/core';
import { Vehicle } from '../../Models/Vehicle';
import { VehicleService } from '../../Services/vehicle.service';
import { LoginService } from '../../Services/login.service';


@Component({
  selector: 'app-add-vehicle',
  templateUrl: './add-vehicle.component.html',
  styleUrl: './add-vehicle.component.css'
})
export class AddVehicleComponent implements OnInit {
  car: Vehicle = new Vehicle(0, '', '', '', 0, 0, '', 0, 0, 0, 0, ''); 
  displayCarForm: boolean = false;
  
  constructor(private vehicleService: VehicleService,
   private loginService: LoginService
  ) { }

  ngOnInit(): void {
  }

  submitForm() {
    this.vehicleService.createCar(this.car).subscribe(response => {
      // Reacționează la răspunsul de la backend, poți să adaugi notificări sau să faci alte acțiuni
      console.log('Car created successfully:', response);
    }, error => {
      console.error('Error creating car:', error);
    });
  }
  showCarForm() {
    this.displayCarForm = !this.displayCarForm; 
     }
  
  getRolefromToken(){
    return this.loginService.getRolefromToken();
  }
}