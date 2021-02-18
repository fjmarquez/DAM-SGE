import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TablaPersonasComponent } from './componentes/tabla-personas/tabla-personas.component';
import { ListaPersonasComponent } from './componentes/lista-personas/lista-personas.component';
import { FormularioPersonasComponent } from './componentes/formulario-personas/formulario-personas.component';
import { MenuComponent } from './componentes/menu/menu.component';

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
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
