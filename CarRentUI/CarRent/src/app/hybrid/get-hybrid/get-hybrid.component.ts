import { Component, OnInit } from '@angular/core';
import { GetHybridService } from '../../services/hybrid/get-hybrid.service';
import { DeleteHybridService } from '../../services/hybrid/delete-hybrid.service';
import { ImageConvertService } from '../../services/ImageConverter/image-convert.service';

@Component({
  selector: 'app-get-hybrid',
  templateUrl: './get-hybrid.component.html',
  styleUrl: './get-hybrid.component.css'
})
export class GetHybridComponent implements OnInit {
  
  hybridCars: HybridCar[] = [];
  filteredCars: HybridCar[];
  nameFilter: string = '';
  modelFilter: string = '';

  constructor(private hybridCarService: GetHybridService,
    private deleteCarService: DeleteHybridService,
    private convertImageService: ImageConvertService) { 
    this.filteredCars = [];
  }

  ngOnInit(): void {
    this.getBackendCars();
  }

  getBackendCars(): void {
    this.hybridCarService.getHybridCars()
      .subscribe(cars => {
        this.hybridCars = cars;
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

  loadImages(): void {
    this.hybridCars.forEach(car => {
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

  applyFilters(): void {
    this.filteredCars = this.hybridCars.filter(car =>
      car.brand.toLowerCase().includes(this.nameFilter.toLowerCase())&&
      car.model.toLowerCase().includes(this.modelFilter.toLowerCase())
    );
  }
}

// electric-car.model.ts
export interface HybridCar {
  id: number;
  brand: string;
  distance: number;
  photo: string;
  price: number;
  model: string;
  year: number;
  enginePower: number;
  electricPower: number;
}

