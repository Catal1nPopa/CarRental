import { Component } from '@angular/core';
import { VehicleService } from '../../Services/vehicle.service';
import { RentalsService } from '../../Services/rentals.service';
import { InspectionService } from '../../Services/inspection.service';
import { Vehicle } from '../../Models/Vehicle';
import { UpdateVehicleStatus } from '../../Models/UpdateVehicleStatus';
import { ClientsService } from '../../Services/clients.service';
import { Client } from '../../Models/Clients';
import { LoginService } from '../../Services/login.service';
import { Inspection } from '../../Models/Inspection';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrl: './admin-page.component.css'
})
export class AdminPageComponent {

  rentals: any[] = []; 
  inspections: any[] = [];
  vehicle: Vehicle = new Vehicle(0, '0', '', '', 0, 0, '', 0, 0, 0, 0, ''); 
  id: number = 0;
  typeVehicle: string = '0';
  createInspection: Inspection = new Inspection("", new Date(),false);
  inspectionForm: FormGroup;
  rentalsFilter = '';
  inspectionsFilter = '';
  
  vehicles: string[] = ['Mașină Hybrid', 'Mașină Combustibil', 'Mașină Electrică', 'Motocicletă Electrică', 'Motocicletă Combustibil'];
  selectedVehicleIndex: number = 0;

  user = { userName: '', RoleName: '' };
  
  constructor(private InspectionService: InspectionService,
    private rentalService: RentalsService,
    private vehicleService: VehicleService,
    private loginService : LoginService,
    private fb: FormBuilder,
    private clientService: ClientsService
  ) {this.inspectionForm = this.fb.group({
    carNumber: ['', Validators.required],
    date: ['', Validators.required],
    advanceInspection: [false]
  }); }
  
  ngOnInit(): void {
    this.getAllRentals();
    this.getInspections();
  }
 
  chengeRole() {
    if (this.user.userName && this.user.RoleName) {
      this.clientService.changeRole(this.user).subscribe(response => {
        console.log('Response from backend:', response);
      });
    }
  }
 
  onVehicleChange(event: Event) {
    const target = event.target as HTMLSelectElement;
    this.typeVehicle = String(target.value);
    console.log('Selected vehicle index:', this.selectedVehicleIndex);
  }

  onSubmit(): void {
    if (this.inspectionForm.valid) {
      const newInspection = new Inspection(
        this.inspectionForm.value.carNumber,
        new Date(this.inspectionForm.value.date),
        this.inspectionForm.value.advanceInspection
      );
      this.InspectionService.createInspect(newInspection).subscribe(
        res => console.log(res),
        err => console.error(err)
      );
    }
  }

  deleteRental(id:number){
    this.rentalService.deleteRentals(id).subscribe((res : any) => {
      console.log(res);
        });
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


  getRolefromToken(){
    return this.loginService.getUserRole();
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

  convertToBase64(photo: string): string {
    return 'data:image/png;base64,' + photo;
  }
}
const dataToUpdate: UpdateVehicleStatus = {
  id: 0,
  vehicleType: ""
};

