import { Injectable } from '@angular/core';
import {DetailsService} from './details.service';
import {Observable} from 'rxjs';
import {Detail} from '../models/detail';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiDetailsService implements DetailsService {

  constructor(private http: HttpClient) { }

  GetDetails(advertId: string): Observable<Detail> {
    return this.http.get<Detail>('https://localhost:5001/details/' + advertId);
  }
}
