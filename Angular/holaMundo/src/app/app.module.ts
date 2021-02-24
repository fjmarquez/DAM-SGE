import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TablaPersonasComponent } from './componentes/tabla-personas/tabla-personas.component';
import { ListaPersonasComponent } from './componentes/lista-personas/lista-personas.component';
import { FormularioPersonasComponent } from './componentes/formulario-personas/formulario-personas.component';
import { MenuComponent } from './componentes/menu/menu.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatSliderModule} from '@angular/material/slider';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';





@NgModule({
  declarations: [
    AppComponent,
    TablaPersonasComponent,
    ListaPersonasComponent,
    FormularioPersonasComponent,
    MenuComponent
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatProgressSpinnerModule,
    MatSliderModule,
    MatSlideToggleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
