import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ClientService } from 'src/app/client.service';
import { Client } from 'src/app/Client';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})
export class ClientsComponent {
  formulario: any;
  tituloFormulario: any;

  constructor(private clientService: ClientService) {}

  ngOnInit(): void{

    this.tituloFormulario = 'Novo Cliente'
    this.formulario = new FormGroup({

      Name: new FormControl(null),
      CNPJ: new FormControl(null),
      FantasyName: new FormControl(null),
      CPF: new FormControl(null),
      StateIncrition: new FormControl(null),
      Phone: new FormControl(null),
      ResidentialPhone: new FormControl(null),
      Adress: new FormControl(null),
      AdressNumber: new FormControl(null),
      Complement: new FormControl(null),
      CEP: new FormControl(null),
      District: new FormControl(null),
      City: new FormControl(null),
      State: new FormControl(null),
      Country: new FormControl(null),
      ClientStatus: new FormControl(null)

    });
  }

  EnviarFormulario(): void{
    const client: Client = this.formulario.value;

    this.clientService.AddClient(client).subscribe((resultado) => {
      alert('Pessoa Inserida com sucesso"');
    });

  }



}
