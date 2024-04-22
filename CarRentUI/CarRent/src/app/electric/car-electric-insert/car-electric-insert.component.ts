import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InsertElectricService } from '../../services/electric/insert-electric.service';

@Component({
  selector: 'app-car-electric-insert',
  templateUrl: './car-electric-insert.component.html',
  styleUrl: './car-electric-insert.component.css'
})
export class CarElectricInsertComponent {
  carForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private InsertCarsService: InsertElectricService) {
    this.carForm = this.formBuilder.group({
      brand: ['', Validators.required],
      model: ['', Validators.required],
      year: ['', Validators.required],
      photo: ['', Validators.required],
      distance: ['', Validators.required],
      price: ['', Validators.required],
      state: [true],
      batteryCapacity: ['', Validators.required],
      electricPower: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.carForm.valid) {
      this.InsertCarsService.insertCar(this.carForm.value).subscribe(
        response => {
          console.log('Mașina a fost inserată cu succes:', response);
        },
        error => {
          console.error('Eroare la inserarea mașinii:', error);
        }
      );
    }
  }
}
