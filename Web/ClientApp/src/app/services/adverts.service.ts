import {Observable} from 'rxjs';
import {Advert} from '../models/advert';

export interface AdvertsService {
  getAdverts(): Observable<Advert[]>;
}
