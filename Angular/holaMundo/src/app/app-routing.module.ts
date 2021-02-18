import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TablaPersonasComponent } from './componentes/tabla-personas/tabla-personas.component';
import { ListaPersonasComponent } from './componentes/lista-personas/lista-personas.component';
import { FormularioPersonasComponent } from './componentes/formulario-personas/formulario-personas.component';

const routes: Routes = [
  {path: '', redirectTo: '/tabla', pathMatch : 'full'},
  {path: 'tabla', component: TablaPersonasComponent},
  {path: 'lista', component: ListaPersonasComponent},
  {path: 'formulario', component: FormularioPersonasComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
