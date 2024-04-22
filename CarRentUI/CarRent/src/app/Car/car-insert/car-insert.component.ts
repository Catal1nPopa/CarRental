import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InsertCarsService } from '../../services/Car/insert-cars.service';

@Component({
  selector: 'app-car-insert',
  templateUrl: './car-insert.component.html',
  styleUrl: './car-insert.component.css'
})
export class CarInsertComponent {
  carForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private InsertCarsService: InsertCarsService) {
    this.carForm = this.formBuilder.group({
      brand: ['', Validators.required],
      model: ['', Validators.required],
      year: ['', Validators.required],
      distance: ['', Validators.required],
      price: ['', Validators.required],
      state: [true]
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
