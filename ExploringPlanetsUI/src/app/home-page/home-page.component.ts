import { Component, OnInit } from '@angular/core';
import { InformationsPlanetService } from '../informations-planet.service';
import { Planet } from '../interfaces/planets';
import { PlanetsService } from '../planets.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

  planets: Planet[] = [];

  constructor(private planetsService: PlanetsService, private infPlanet: InformationsPlanetService) { }

  ngOnInit(): void {
    this.planetsService.getAllPlanets().subscribe(response => {
      this.planets = response
      this.infPlanet.planetMethod(this.planets);
    });
  }

}
