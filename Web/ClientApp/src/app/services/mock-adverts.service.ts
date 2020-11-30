import {Injectable} from '@angular/core';
import {Advert} from '../models/advert';
import {Observable, of} from 'rxjs';
import {AdvertsService} from './adverts.service';

@Injectable()
export class MockAdvertsService implements AdvertsService{

  getAdverts(): Observable<Advert[]> {
    let adverts: Advert[];
    adverts = [
        {
          advertId: '',
          memberId: '',
          heroImage: '',
          price: 0,
          vertical: '',
          dateLastUpdated: new Date(),
          dateCreated: new Date(),
          title: ''
        }
      ];
    return of(adverts);
  }
}
