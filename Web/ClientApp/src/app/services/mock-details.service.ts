import { Injectable } from '@angular/core';
import {DetailsService} from './details.service';
import {Observable, of} from 'rxjs';
import {Detail} from '../models/detail';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MockDetailsService implements DetailsService {

  constructor(private http: HttpClient) { }

  GetDetails(advertId: string): Observable<Detail> {
    return of({
      advertId: '',
      memberId: 'string',
      heroImage: 'string',
      title: 'string',
      vertical: 'string',
      price: 0,
      dateCreated: new Date(),
      dateLastUpdated: new Date(),
      odometer: 0,
      colorInterior: 'string',
      colorExterior: 'string',
      registration: 'string',
      registrationExpiryMonth: 0,
      registrationExpiryYear: 0,
      make: 'string',
      model: 'string',
      year: 0,
      comments: 'string',
      seller: {
        firstName: '',
        surname: '',
        phoneNumber: ''
      },
      location: {
        state: '',
        suburb: '',
        postcode: '',
        country: ''
      },
      photos: [
        {
          mediaId: '',
          secureUrl: ''
        }
      ]
    });
  }
}
