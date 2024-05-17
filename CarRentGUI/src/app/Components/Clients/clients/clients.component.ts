import { Component } from '@angular/core';
import { ClientsService } from '../../../Services/clients.service';
import { LoginService } from '../../../Services/login.service';
import { NgToastService } from 'ng-angular-popup';
import { Client } from '../../../Models/Clients';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrl: './clients.component.css'
})
export class ClientsComponent {

  clientList!: any[];
  client: Client = new Client(0,"",new Date(),"",0);

  constructor(private clientService: ClientsService
  ) { }
  ngOnInit(): void {
    this.getClients();
  }

  getClients(): void{
    this.clientService.getAllClients().
    subscribe(data => {
      this.clientList = data;
    })
  }
}
