import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Advert} from '../models/advert';
import {AdvertsService} from './adverts.service';

@Injectable()
export class ApiAdvertService implements AdvertsService{
  constructor(private http: HttpClient) {}
  adverts: Advert[];
  getAdverts(): Observable<Advert[]> {
    return this.http.get<Advert[]>('https://localhost:5001/adverts');
  }
}
