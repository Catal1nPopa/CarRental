import { Component, OnInit } from '@angular/core';
import { Vehicle } from '../../Models/Vehicle';
import { VehicleService } from '../../Services/vehicle.service';


@Component({
  selector: 'app-add-vehicle',
  templateUrl: './add-vehicle.component.html',
  styleUrl: './add-vehicle.component.css'
})
export class AddVehicleComponent implements OnInit {
  car: Vehicle = new Vehicle(0, '', '', '', 0, 0, '', 0, 0, 0, 0, ''); 

  constructor(private vehicleService: VehicleService) { }

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
}