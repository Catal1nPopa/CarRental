import { Component, OnInit } from '@angular/core';
import { Vehicle } from '../../Models/Vehicle';
import { VehicleService } from '../../Services/vehicle.service';
import { LoginService } from '../../Services/login.service';
import { NgToastService } from 'ng-angular-popup';


@Component({
  selector: 'app-add-vehicle',
  templateUrl: './add-vehicle.component.html',
  styleUrl: './add-vehicle.component.css'
})
export class AddVehicleComponent implements OnInit {
  car: Vehicle = new Vehicle(0, '', '', '', 0, 0, '', 0, 0, 0, 0, ''); 
  displayCarForm: boolean = false;
  
  constructor(private vehicleService: VehicleService,
   private loginService: LoginService,private toast : NgToastService
  ) { }

  ngOnInit(): void {
  }

  createCar() {
    this.vehicleService.createCar(this.car).subscribe(response => {
      // Reacționează la răspunsul de la backend, poți să adaugi notificări sau să faci alte acțiuni
      console.log('Car created successfully:', response);
      this.toast.success({detail:"SUCCESS",summary:'Adăugare cu succes',duration:5000});
    }, error => {
      console.error('Error creating car:', error);
      this.toast.error({detail:"ERROR",summary:'Eroare la adăugare',sticky:true});
    });
  }

  submitForm(){
if (this.car.photo) {
      this.convertAttachmentToBase64()
        .then(() => this.createCar());
    } else {
      this.createCar();
    }
  }

  showCarForm() {
    this.displayCarForm = !this.displayCarForm; 
     }
  
  getRolefromToken(){
    return this.loginService.getUserRole();
  }


  private async convertAttachmentToBase64(): Promise<void> {
    const attachmentInput = document.getElementById('photo') as HTMLInputElement;
    if (attachmentInput.files && attachmentInput.files[0]) {
      const file = attachmentInput.files[0];
      const reader = new FileReader();
      reader.readAsDataURL(file);
      return new Promise<void>((resolve, reject) => {
        reader.onload = () => {
          let base64String = reader.result as string;
          if (base64String.startsWith('data:image')) {
            base64String = base64String.replace(/^data:image\/(png|jpg|jpeg|gif);base64,/, '');
          }
          this.car.photo = base64String;
          resolve();
        };
        reader.onerror = (error) => reject(error);
      });
    } else {
      return Promise.reject("No file selected");
    }
  }
}