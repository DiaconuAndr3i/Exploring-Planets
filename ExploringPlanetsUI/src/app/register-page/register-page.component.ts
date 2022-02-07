import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthentificationService } from '../authentification.service';
import { CrewService } from '../crew.service';
import { robot } from '../interfaces/robot';
import { Crew } from '../ModelsDTO/crew';
import { Register } from '../ModelsDTO/registerDTO';
import { RobotsService } from '../robots.service';

@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.css']
})
export class RegisterPageComponent implements OnInit {


  Robots: robot[] = [];

  idRobots: string[] = [];
  idUser?: string;

  registrationForm = this.fb.group({
    firstName: ['', [Validators.required, Validators.minLength(2)]],
    lastName: ['', [Validators.required, Validators.minLength(2)]],
    email: ['', [Validators.required, Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")]],
    password: ['', Validators.required],
  });

  constructor(private robots: RobotsService, private fb : FormBuilder, 
    private auth: AuthentificationService, private crewService: CrewService) { }

  ngOnInit(): void {
    this.robots.getAvailableRobots().subscribe(response => this.Robots = response);
  }

  createCrew(idRobot: string){
    this.idRobots.push(idRobot);
  }

  clearIdRobotsList(){
    this.idRobots = [];
  }

  onRegister(){
    var registrationData = new Register();
    var timestamp = String(Date.now())

    registrationData.Email = this.registrationForm.value.email;
    registrationData.FirstName = this.registrationForm.value.firstName;
    registrationData.LastName = this.registrationForm.value.lastName;
    registrationData.Password = this.registrationForm.value.password;
    registrationData.Id = timestamp;

    var crewData = new Crew();
    crewData.UserId = timestamp;
    crewData.RobotIds = this.idRobots; 

    this.auth.register(registrationData).subscribe(() => {
      this.crewService.createCrew(crewData).subscribe();
    });
    
  }

}
