import { Component, OnInit } from '@angular/core';
import { RentalsService } from '../../Services/rentals.service';

@Component({
  selector: 'app-rental-list',
  templateUrl: './rental-list.component.html',
  styleUrl: './rental-list.component.css'
})
export class RentalListComponent implements OnInit {
  rentals: any;

  constructor(private rentalService: RentalsService) { }

  ngOnInit(): void {
    this.getRentals();
  }

  getRentals(): void {
    this.rentalService.getAllRentals()
      .subscribe(data => {
        this.rentals = data;
        console.log(this.rentals); 
      });
  }
}