import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InsertService } from '../../services/combustion/insert.service';

@Component({
  selector: 'app-insert-combustion',
  templateUrl: './insert-combustion.component.html',
  styleUrl: './insert-combustion.component.css'
})
export class InsertCombustionComponent {
  carForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private InsertCarsService: InsertService) {
    this.carForm = this.formBuilder.group({
      brand: ['', Validators.required],
      model: ['', Validators.required],
      year: ['', Validators.required],
      photo: ['', Validators.required],
      distance: ['', Validators.required],
      price: ['', Validators.required],
      state: [true],
      enginePower: ['', Validators.required]
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
