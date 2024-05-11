import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../../Services/vehicle.service';
import { RentalsService } from '../../Services/rentals.service';
import { RentModel } from '../../Models/RentModel';
import { LoginService } from '../../Services/login.service';
import { NgToastService } from 'ng-angular-popup';
import { UpdateVehicleStatus } from '../../Models/UpdateVehicleStatus';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrl: './vehicle-list.component.css'
})
export class VehicleListComponent implements OnInit {
  vehicleList!: any[];
  rentData: RentModel = new RentModel(0,0,0,"0");
  userId: number = 0;

  constructor(private vehicleService: VehicleService,
    private rentService: RentalsService,
    private authService: LoginService,
    private toast : NgToastService
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

  getRolefromToken(){
    return this.authService.getRolefromToken();
  }

  deleteVehicle(): void {
    // console.log("accesat")
    this.vehicleService.deleteVehicle(this.rentData.idCar, this.rentData.vehicleTypes)
      .subscribe(
        () => {
          this.toast.success({detail:"SUCCESS",summary:'Stergere cu succes',duration:5000});
          console.log('Vehicol ștears cu succes!');
          this.getVehicles();
        },
        error => {
          this.toast.error({detail:"ERROR",summary:'Eroare la stergere',duration:5000});
          console.error('Eroare la ștergere:', error);
        }
      );
  }

  
  updateVehicleStatus(): void{
    dataToUpdate.id = this.rentData.idCar;
    dataToUpdate.vehicleType = this.rentData.vehicleTypes;
    this.vehicleService.updateVehicleStatus(dataToUpdate).subscribe(response => {
      console.log(response); // poți face orice cu răspunsul de la server
    }, error => {
      console.error(error); // gestionează erorile în mod corespunzător
    });
  }
}
const dataToUpdate: UpdateVehicleStatus = {
  id: 0,
  vehicleType: ""
};