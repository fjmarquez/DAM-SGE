import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-formulario-personas',
  templateUrl: './formulario-personas.component.html',
  styleUrls: ['./formulario-personas.component.css']
})
export class FormularioPersonasComponent implements OnInit {

  nombre:string;
  apellidos:string;

  constructor() {
    this.nombre = "";
    this.apellidos = "";
   }

  ngOnInit(): void {
  }

  saludar(nombre:string, apellidos:string){
    alert("Hola " + nombre + " " + apellidos);
  }

}
