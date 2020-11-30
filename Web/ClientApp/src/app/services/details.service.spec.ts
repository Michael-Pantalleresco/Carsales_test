import { TestBed } from '@angular/core/testing';

import { ApiDetailsService } from './api-details.service';
import {HttpClientTestingModule, HttpTestingController} from '@angular/common/http/testing';

describe('DetailsService', () => {
  let service: ApiDetailsService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ApiDetailsService]
    });
    service = TestBed.inject(ApiDetailsService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should get adverts from api ', () => {
    const expected =
      {
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
      };

    service.GetDetails('1234').subscribe(details => {
      expect(details).toBeTruthy();
      expect(details).toBe(expected);
    });
    const request = httpMock.expectOne('https://localhost:5001/details/1234');
    expect(request.request.method).toBe('GET');
    request.flush(expected);
  });
});
