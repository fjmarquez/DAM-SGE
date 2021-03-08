import { Injectable } from '@angular/core';
import { Persona } from 'src/app/interfaces/persona';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonasServiceService {

  urlWebAPI = 'https://fjmarquezcrudnet.azurewebsites.net/api/personas';

  constructor(private http:HttpClient) {  }

  listadoPersonas() : Observable<Persona[]>{
    return this.http.get<Persona[]>(this.urlWebAPI);
  }

}
