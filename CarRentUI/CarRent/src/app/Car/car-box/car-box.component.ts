import { Component, OnInit } from '@angular/core';
import { GetCarsService } from '../../services/Car/get-cars.service';
import { DeleteCarsService } from '../../services/Car/delete-cars.service';


@Component({
  selector: 'app-car-box',
  templateUrl: './car-box.component.html',
  styleUrl: './car-box.component.css'
})
export class CarBoxComponent implements OnInit{

  cars: Car[] = [];
  filteredCars: Car[];
  nameFilter: string = '';
  modelFilter: string = '';

  constructor(private carService: GetCarsService,
    private deleteCarService: DeleteCarsService){
    this.filteredCars = [];
  }

  ngOnInit(): void {
    this.getBackendCars();
  }

  getBackendCars(): void {
    this.carService.getCars()
      .subscribe(cars => {
        this.cars = cars;
        this.applyFilters();
      });
  }
  
  deleteCar(carId: number): void {
    if (confirm('Are you sure you want to delete this car?')) {
      this.deleteCarService.deleteCar(carId)
        .subscribe(() => {
          // Actualizează lista de mașini după ștergere
          this.getBackendCars();
        });
    }
  }

  applyFilters(): void {
    this.filteredCars = this.cars.filter(car =>
      car.brand.toLowerCase().includes(this.nameFilter.toLowerCase()) &&
      car.model.toLowerCase().includes(this.modelFilter.toLowerCase())
    );
  }
  
}



export interface Car {
  id: number;
  brand: string;
  model: string;
  year: number;
  distance: number;
  photo: string; // Vom trata fotografia ca un șir de caractere pentru a reprezenta URL-ul sau calea imaginii
  state: boolean; // Starea mașinii (activă/inactivă)
  price : number;
}