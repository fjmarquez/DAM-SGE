import { Component, OnInit } from '@angular/core';
import { Persona } from 'src/app/interfaces/persona';
import { PersonasServiceService } from 'src/app/services/personas-service.service';

@Component({
  selector: 'app-tabla-api',
  templateUrl: './tabla-api.component.html',
  styleUrls: ['./tabla-api.component.css']
})
export class TablaAPIComponent implements OnInit {

  listadoPersonas:Persona[];

  constructor(private personaService:PersonasServiceService) { }

  ngOnInit(): void {

    this.personaService.listadoPersonas().subscribe(
      data => {
      this.listadoPersonas = data;
      console.log(this.listadoPersonas);
    }, error => {
      console.log(error);
    });

  }

}
