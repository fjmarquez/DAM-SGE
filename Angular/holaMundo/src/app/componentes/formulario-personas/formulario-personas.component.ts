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

      direccion:new FormControl('calle',[Validators.min(5)]),

      fechaNacimiento: new FormControl('',[/*Validators.pattern('/^((0[13578]|1[02])[\/.]31[\/.](18|19|20)[0-9]{2})|((01|0[3-9]|1[1-2])[\/.](29|30)[\/.](18|19|20)[0-9]{2})|((0[1-9]|1[0-2])[\/.](0[1-9]|1[0-9]|2[0-8])[\/.](18|19|20)[0-9]{2})|((02)[\/.]29[\/.](((18|19|20)(04|08|[2468][048]|[13579][26]))|2000))$/')*/]),

      telefono: new FormControl('',[Validators.pattern('^34(?:6[0-9]|7[1-9])[0-9]{7}$')]),

      departamento: new FormControl('', [Validators.required])
    
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
