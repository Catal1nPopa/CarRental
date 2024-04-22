// electric-car.component.ts
import { Component, OnInit } from '@angular/core';
import { GetElectricService } from '../../services/electric/get-electric.service';
import { DeleteEletricCarsService } from '../../services/electric/delete-eletric-cars.service';
import { ImageConvertService } from '../../services/ImageConverter/image-convert.service';

@Component({
  selector: 'app-electric-car',
  templateUrl: './electric-car.component.html',
  styleUrl: './electric-car.component.css'
})
export class ElectricCarComponent implements OnInit {
  
  electricCars: ElectricCar[] = [];
  filteredCars: ElectricCar[];
  nameFilter: string = '';
  modelFilter: string = '';

  constructor(private electricCarService: GetElectricService,
    private deleteCarService: DeleteEletricCarsService,
    private convertImageService: ImageConvertService) { 
    this.filteredCars = [];
  }

  ngOnInit(): void {
    this.getBackendCars();
  }

  getBackendCars(): void {
    this.electricCarService.getElectricCars()
      .subscribe(cars => {
        this.electricCars = cars;
        this.applyFilters();
      });
  }
  loadImages(): void {
    this.electricCars.forEach(car => {
      const byteArray = this.convertBase64ToArray(car.photo);
      this.convertImageService.getImageFromByteArray(byteArray).subscribe(imageData => {
        car.photo = imageData; 
      });
    });
  }
  
  convertBase64ToArray(base64String: string): number[] {
    const binaryString = window.atob(base64String);
    const byteArray: number[] = [];
    for (let i = 0; i < binaryString.length; i++) {
      byteArray.push(binaryString.charCodeAt(i));
    }
    return byteArray;
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
    this.filteredCars = this.electricCars.filter(car =>
      car.brand.toLowerCase().includes(this.nameFilter.toLowerCase())&&
      car.model.toLowerCase().includes(this.modelFilter.toLowerCase())
    );
  }
}

// electric-car.model.ts
export interface ElectricCar {
  id: number;
  brand: string;
  distance: number;
  photo: string;
  price: number;
  model: string;
  year: number;
  batteryCapacity: number;
  electricPower: number;
}
