import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InsertHybridService } from '../../services/hybrid/insert-hybrid.service';

@Component({
  selector: 'app-insert-hybrid',
  templateUrl: './insert-hybrid.component.html',
  styleUrl: './insert-hybrid.component.css'
})
export class InsertHybridComponent {
  carForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private InsertCarsService: InsertHybridService) {
    this.carForm = this.formBuilder.group({
      brand: ['', Validators.required],
      model: ['', Validators.required],
      photo: ['', Validators.required],
      year: ['', Validators.required],
      distance: ['', Validators.required],
      price: ['', Validators.required],
      state: [true],
      enginePower: ['', Validators.required],
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
