import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-formulario-personas',
  templateUrl: './formulario-personas.component.html',
  styleUrls: ['./formulario-personas.component.css']
})

export class FormularioPersonasComponent implements OnInit {

  /*nombre:string;
  apellidos:string;*/

  formulario:FormGroup;

  constructor() {
    /*this.nombre = "";
    this.apellidos = "";*/
   }

  ngOnInit(): void {

    this.formulario=new FormGroup(


      {
      
      nombre: new FormControl('',[Validators.required]),
      
      apellidos:new FormControl('',[Validators.required]),

      direccion:new FormControl('calle',[]),

      fechaNacimiento: new FormControl('10-10-2021',[]),

      telefono: new FormControl('',[]),

      departamento: new FormControl()
      
      }
      
      );

  }

  saludar(){

    if(this.formulario.valid){
      alert('Hola ' + this.formulario.controls.nombre.value + ' ' + this.formulario.controls.apellidos.value);

    }


  }

  /*saludar(nombre:string, apellidos:string){
    alert("Hola " + nombre + " " + apellidos);
  }*/

}
