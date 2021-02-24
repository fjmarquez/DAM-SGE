import { Component, OnInit } from '@angular/core';
import{ Router, RouterLink } from '@angular/router';


@Component({
  selector: 'app-tabla-personas',
  templateUrl: './tabla-personas.component.html',
  styleUrls: ['./tabla-personas.component.css']
})
export class TablaPersonasComponent implements OnInit {

  constructor(private route:Router) { }

  ngOnInit(): void {
  }

  navegarListado(){
    this.route.navigate(['/lista']);
  }

}
