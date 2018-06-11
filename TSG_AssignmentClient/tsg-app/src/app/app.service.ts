import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  baseUrl: string = `http://localhost:60870/tsgAssignment/getImages`;
  constructor(private http: HttpClient) { }

  getSettings(): Observable<any> {
    return this.http.get(this.baseUrl);
  }

}
