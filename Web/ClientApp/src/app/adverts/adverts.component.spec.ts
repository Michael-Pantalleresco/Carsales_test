import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AdvertsComponent } from './adverts.component';
import {HttpClientTestingModule} from '@angular/common/http/testing';
import {DebugElement} from '@angular/core';
import {MockAdvertsService} from '../services/mock-adverts.service';
import {AdvertsService} from '../services/adverts.service';
import {ApiAdvertService} from '../services/api-advert.service';

describe('AdvertsComponent', () => {
  let component: AdvertsComponent;
  let fixture: ComponentFixture<AdvertsComponent>;
  let componentService: AdvertsService;
  let componentDebug: DebugElement;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ApiAdvertService],
      declarations: [AdvertsComponent]
    })
    .compileComponents();
  });

  beforeEach(() => {
    TestBed.overrideComponent(AdvertsComponent,
      {set: { providers: [ {provide: ApiAdvertService, useClass: MockAdvertsService} ]}});

    fixture = TestBed.createComponent(AdvertsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
    componentService = fixture.debugElement.injector.get(ApiAdvertService);
    componentDebug = fixture.debugElement;
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render the number of listings', () => {
    const page: HTMLElement = componentDebug.nativeElement;
    const title = page.querySelector('div .car-listing-total');
    expect(title.textContent.trim().toString()).toEqual('1 vehicles for sale in Australia');
  });

  it('should render the car listings', () => {
    const page: HTMLElement = componentDebug.nativeElement;
    const listings = page.querySelector('div .car-listing');
    expect(listings).toBeTruthy();
    expect(listings.className).toContain('col-6');
  });
});
