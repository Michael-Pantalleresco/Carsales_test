import { TestBed } from '@angular/core/testing';

import { ApiAdvertService } from './api-advert.service';
import {HttpClientTestingModule, HttpTestingController} from '@angular/common/http/testing';

describe('AdvertsService', () => {
  let service: ApiAdvertService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ApiAdvertService]
    });

    service = TestBed.inject(ApiAdvertService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  it('should create', () => {
    expect(service).toBeTruthy();
  });

  it('should get adverts from api ', () => {
    const expected = [
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
    service.getAdverts().subscribe(adverts =>
      expect(adverts.length).toBe(1)
    );
    const request = httpMock.expectOne('https://localhost:5001/adverts');
    expect(request.request.method).toBe('GET');
    request.flush(expected);
  });
});
