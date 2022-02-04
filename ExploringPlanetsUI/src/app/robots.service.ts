import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { robot } from './interfaces/robot';

@Injectable({
  providedIn: 'root'
})
export class RobotsService {


  URL = 'https://localhost:5001';

  constructor(private http: HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getAvailableRobots(): Observable<any>{
    const url = `${this.URL}/availableRobotsForMission`;
    return this.http.get<robot[]>(url);
  }

}
