import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../../Services/vehicle.service';
import { RentalsService } from '../../Services/rentals.service';
import { RentModel } from '../../Models/RentModel';
import { LoginService } from '../../Services/login.service';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrl: './vehicle-list.component.css'
})
export class VehicleListComponent implements OnInit {
  vehicleList!: any[];
  rentData: RentModel = new RentModel(110,110,110,"0");
  userId: number = 0;
  
  constructor(private vehicleService: VehicleService,
    private rentService: RentalsService,
    private authService: LoginService
  ) { }

  ngOnInit(): void {
    this.getVehicles();
  }

  getVehicles(): void {
    this.vehicleService.getAllVehicles()
      .subscribe(data => {
        this.vehicleList = data;
        console.log(this.vehicleList); 
      });
  }

  convertToBase64(photo: string): string {
    return 'data:image/png;base64,' + photo;
  }

  toggleVehicleDetails(data: any)
  {
    data.showDetails = !data.showDetails;
    this.rentData.idCar = data.id;
    this.rentData.vehicleTypes = data.vehicleType;
    this.rentData.CustomerId = this.authService.getUserIdFromToken();
  }

  onSubmit(): void {
    this.rentService.createRental(this.rentData)
      .subscribe(
        response => {
          console.log("Rental created successfully:", response);
          this.getVehicles();
          // Dacă dorești să faci ceva după ce rental-ul a fost creat cu succes, adaugă codul aici
        },
        error => {
          console.error("Error creating rental:", error);
          // În cazul în care apare o eroare în timpul creării rental-ului, afișează un mesaj corespunzător către utilizator
        }
      );
  }
}
