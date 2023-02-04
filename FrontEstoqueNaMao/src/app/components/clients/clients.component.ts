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

    this.tituloFormulario = 'Novo Cliente';
    this.formulario = new FormGroup({
      name: new FormControl(null),
      fantasyName: new FormControl(null),
      cnpj: new FormControl(null),
      cpf: new FormControl(null),
      stateIncrition: new FormControl(null),
      phone: new FormControl(null),
      residentialPhone: new FormControl(null),
      adress: new FormControl(null),
      adressNumber: new FormControl(null),
      complement: new FormControl(null),
      cep: new FormControl(null),
      district: new FormControl(null),
      city: new FormControl(null),
      state: new FormControl(null),
      country: new FormControl(null)
    });
  }

  EnviarFormulario(): void{
    const client: Client = this.formulario.value;

    this.clientService.Post(client).subscribe((resultado) => {
      alert('Pessoa Inserida com sucesso');
    });

  }
}
