import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-formulario-reactivo',
  templateUrl: './formulario-reactivo.component.html',
  styleUrls: ['./formulario-reactivo.component.css']
})
export class FormularioReactivoComponent implements OnInit {

  formulario:FormGroup;

  constructor() { }

  ngOnInit(): void {

    this.formulario=new FormGroup(


      {
      
      nombre: new FormControl('',[Validators.required]),
      
      apellidos:new FormControl('',[Validators.required])
    
    }
      
      );

  }

  
  saludar(){

    //if(this.formulario.valid){
      alert('Hola ' + this.formulario.controls.nombre.value + ' ' + this.formulario.controls.apellidos.value);

    //}


  }

}
