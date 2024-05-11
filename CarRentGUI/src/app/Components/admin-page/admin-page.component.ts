import { Component } from '@angular/core';
import { VehicleService } from '../../Services/vehicle.service';
import { RentalsService } from '../../Services/rentals.service';
import { InspectionService } from '../../Services/inspection.service';
import { Vehicle } from '../../Models/Vehicle';
import { UpdateVehicleStatus } from '../../Models/UpdateVehicleStatus';

@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrl: './admin-page.component.css'
})
export class AdminPageComponent {

  rentals: any[] = []; 
  inspections: any[] = [];
  vehicle: Vehicle = new Vehicle(0, '', '', '', 0, 0, '', 0, 0, 0, 0, ''); 
  id: number = 0;
  typeVehicle: string = '0';

  constructor(private InspectionService: InspectionService,
    private rentalService: RentalsService,
    private vehicleService: VehicleService
  ) { }

  ngOnInit(): void {
    this.getAllRentals();
    this.getInspections();
    // this.getVehicle();
  }


  getAllRentals(){
    this.rentalService.getAllRentals().subscribe((data: any[]) => {
      this.rentals = data;
    });
  }

  getInspections(){
    this.InspectionService.getAllInspections().subscribe((data: any[]) => {
      this.inspections = data;
    })
  }

  getVehicle(): void{
    dataToUpdate.id = this.id;
    dataToUpdate.vehicleType = this.typeVehicle;
    this.vehicleService.getVehicle(dataToUpdate).subscribe(response => {
      //window.location.reload();
        this.vehicle = response;
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

