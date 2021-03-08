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
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatSliderModule } from '@angular/material/slider';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatFormFieldModule } from '@angular/material/form-field'; 
import { MatCardModule } from '@angular/material/card'; 
import { MatInputModule } from '@angular/material/input';
import { FormularioReactivoComponent } from './componentes/formulario-reactivo/formulario-reactivo.component';
import { HttpClientModule } from '@angular/common/http';
import { TablaAPIComponent } from './componentes/tabla-api/tabla-api.component';



@NgModule({
  declarations: [
    AppComponent,
    TablaPersonasComponent,
    ListaPersonasComponent,
    FormularioPersonasComponent,
    MenuComponent,
    FormularioReactivoComponent,
    TablaAPIComponent
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatProgressSpinnerModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatFormFieldModule,
    MatCardModule,
    MatInputModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
