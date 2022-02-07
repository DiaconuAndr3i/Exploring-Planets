import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { InformationsPlanetService } from '../informations-planet.service';
import { Planet } from '../interfaces/planets';
import { Description } from '../ModelsDTO/descriptionDTO';
import { Status } from '../ModelsDTO/statusDTO';
import { PlanetsService } from '../planets.service';

@Component({
  selector: 'app-planet',
  templateUrl: './planet.component.html',
  styleUrls: ['./planet.component.css']
})
export class PlanetComponent implements OnInit, OnDestroy {

  planets: Planet[] = [];
  subscription: Subscription;
  selectedMember: Boolean = false;
  indexMember: Number = 0;
  userId?: string;

  updateForm = this.fb.group({
    description: [''],
    status: ['']
  });


  constructor(private infoPlanet: InformationsPlanetService, private fb: FormBuilder, 
    private planetService: PlanetsService, private route: ActivatedRoute,
    private router: Router) {
    this.subscription = this.infoPlanet.informationsPlanet$.subscribe((response: Planet[]) => {
      this.planets = response;
    });
   }

  ngOnInit(): void {
    this.userId = String(this.route.snapshot.paramMap.get('userId')); 
  }

  selected(ind: Number){
    if(this.selectedMember==false){
      this.selectedMember = true;
    }
    else{
      this.selectedMember = false;
    }
    this.indexMember = ind;
  }

  refreshComponent(){
    window.location.reload();
  }

  onUpdate(planetId: string){

    if (this.updateForm.value.status != ''){
      var statusData = new Status();
      statusData.UserId = this.userId;
      statusData.IdPlanet = planetId;
      statusData.Status = this.updateForm.value.status;
      this.planetService.updateStatus(statusData).subscribe(() => {
        this.refreshComponent()
      });
    }
    if (this.updateForm.value.description != ''){
      var descriptionData = new Description();
      descriptionData.UserId = this.userId;
      descriptionData.IdPlanet = planetId;
      descriptionData.Description = this.updateForm.value.description;
      this.planetService.updateDescription(descriptionData).subscribe(() => {
        this.refreshComponent();
      });
    }

  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }

}
