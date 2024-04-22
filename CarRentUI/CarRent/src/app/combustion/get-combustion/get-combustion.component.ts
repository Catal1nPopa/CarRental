import { Component, OnInit } from '@angular/core';
import { GetService } from '../../services/combustion/get.service';
import { DeleteService } from '../../services/combustion/delete.service';
import { ImageConvertService } from '../../services/ImageConverter/image-convert.service';

@Component({
  selector: 'app-get-combustion',
  templateUrl: './get-combustion.component.html',
  styleUrl: './get-combustion.component.css'
})
export class GetCombustionComponent implements OnInit {
  
  combustionCars: CombustionCar[] = [];
  filteredCars: CombustionCar[];
  nameFilter: string = '';
  modelFilter: string = '';

  constructor(private combustionCarService: GetService,
    private deleteCarService: DeleteService,
    private convertImageService: ImageConvertService) { 
    this.filteredCars = [];
  }

  ngOnInit(): void {
    this.getBackendCars();
  }

  getBackendCars(): void {
    this.combustionCarService.getCombustionCars()
      .subscribe(cars => {
        this.combustionCars = cars;
        this.loadImages();
        this.applyFilters();
      });
  }
  loadImages(): void {
    this.combustionCars.forEach(car => {
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
    this.filteredCars = this.combustionCars.filter(car =>
      car.brand.toLowerCase().includes(this.nameFilter.toLowerCase())&&
      car.model.toLowerCase().includes(this.modelFilter.toLowerCase())
    );
  }
}

// electric-car.model.ts
export interface CombustionCar {
  id: number;
  brand: string;
  distance: number;
  photo: string;
  price: number;
  model: string;
  year: number;
  enginePower: number;
}
