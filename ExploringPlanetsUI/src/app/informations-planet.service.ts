import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Planet } from './interfaces/planets';

@Injectable({
  providedIn: 'root'
})
export class InformationsPlanetService {

  private informationsPlanetSource = new Subject<Planet[]>();

  informationsPlanet$ = this.informationsPlanetSource.asObservable();

  planetMethod(planetData: Planet[]){
    this.informationsPlanetSource.next(planetData);
  }
}
