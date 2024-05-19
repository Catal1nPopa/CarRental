import { Component, OnInit } from '@angular/core';
import { ProfileService } from '../../Services/profile.service';
import { UpdatePhone } from '../../Models/UpdatePhone';
import { User } from '../../Models/User';
import { LoginService } from '../../Services/login.service';
import { userData } from '../../Models/UpdatePassword';
import { NgToastService } from 'ng-angular-popup';
import { RentalsService } from '../../Services/rentals.service';
import { ClientsService } from '../../Services/clients.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent implements OnInit{
  updatePhone: UpdatePhone = new UpdatePhone(0,"0000");
  updatePass: userData = new userData(0,"", "","");
  rentals: any[] = [];
  customerId: number = 0;
  clientData: any;
  userRole: string = '';

  rentalFilter = '';

  constructor(private profileService : ProfileService,
    private loginService: LoginService,
    private toast : NgToastService,
    private rentalsService : RentalsService,
    private clientService : ClientsService
  ){}

  ngOnInit(): void {
    this.getUser();
    this.fetchRentals(this.customerId);
    this.getClientData();
  }

  fetchRentals(id: number) {
    this.rentalsService.getRentalsCustomer(id).subscribe(data => {
      this.rentals = data;
      console.log(this.userRole);
    });
  }

  updatePhoneNumber(): void {
    this.profileService.changePhone(this.updatePhone).subscribe(
      response => {
        this.toast.success({detail:"Success",summary:'Actualizare numar cu succes',sticky:true});
      },
      error => {
        this.toast.error({detail:"ERROR",summary:'Eroare la modificare numar',sticky:true});
      }
    );
  }

  updatePassword(): any {
    console.log("component");
    this.profileService.changePassword(this.updatePass).subscribe((res : any) => {
      this.toast.success({detail:"Success",summary:'Actualizare parolă cu succes',sticky:true});
    },error => {
      this.toast.error({detail:"ERROR",summary:'Eroare la modificare parolă',sticky:true});
    });
  }

  getUser(){
    const userId = this.loginService.getUserIdFromToken();
    const name = this.loginService.getUserName();
    const role = this.loginService.getUserRole();
    this.userRole = role;
    this.updatePhone.id = userId;
    this.updatePass.id = userId;
    this.updatePass.username = name;
    this.updatePass.role = role;
    this.customerId = this.loginService.getUserIdFromToken();
  }

  deleteRental(id:number){
    this.rentalsService.deleteRentals(id).subscribe((res : any) => {
        });
  }

  getClientData(): any{
    console.log(this.clientService.getClient(this.updatePass.username).subscribe((res: any) => {
      this.clientData = res;
    }));
  }
}
