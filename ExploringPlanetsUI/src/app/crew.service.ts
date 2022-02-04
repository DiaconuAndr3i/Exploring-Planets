import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CrewService {

  URL = 'https://localhost:5001';
  httpOptions = {
    headers:  new HttpHeaders({'Content-Type': 'application/json'})
  };
  
  constructor(private http: HttpClient, private router: Router) { }

  createCrew(crewData: any): Observable<any>{
    debugger
    return this.http.post<any>(`${this.URL}/createCrew`, crewData);
  }

}
