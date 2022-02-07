import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Planet } from './interfaces/planets';

@Injectable({
  providedIn: 'root'
})
export class PlanetsService {

  URL = 'https://localhost:5001';
  httpOptions = {
    headers:  new HttpHeaders({'Content-Type': 'application/json'})
  };


  constructor(private http: HttpClient) { }

  getAllPlanets(): Observable<any>{
    return this.http.get<Planet[]>(`${this.URL}/getAllPlanets`);
  }

  updateStatus(statusData: any): Observable<any>{
    return this.http.put<any>(`${this.URL}/updateStatus`, statusData);
  }

  updateDescription(descriptionData: any): Observable<any>{
    return this.http.put<any>(`${this.URL}/updateDescription`, descriptionData);
  }


}
