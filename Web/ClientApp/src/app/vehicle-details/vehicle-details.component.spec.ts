import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DetailsComponent } from './vehicle-details.component';
import {HttpClientTestingModule} from '@angular/common/http/testing';
import {RouterTestingModule} from '@angular/router/testing';
import {DebugElement} from '@angular/core';
import {ApiDetailsService} from '../services/api-details.service';
import {MockDetailsService} from '../services/mock-details.service';
import {DetailsService} from '../services/details.service';

describe('DetailsComponent', () => {
  let component: DetailsComponent;
  let fixture: ComponentFixture<DetailsComponent>;
  let componentDebug: DebugElement;
  let componentService: DetailsService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsComponent ],
      imports: [HttpClientTestingModule, RouterTestingModule]
    })
    .compileComponents();
  });

  beforeEach(() => {
    TestBed.overrideComponent(DetailsComponent,
      {set: { providers: [ {provide: ApiDetailsService, useClass: MockDetailsService} ]}});

    fixture = TestBed.createComponent(DetailsComponent);
    component = fixture.componentInstance;

    componentService = fixture.debugElement.injector.get(ApiDetailsService);
    componentDebug = fixture.debugElement;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render vehicle listing', () => {
    const page: HTMLElement = componentDebug.nativeElement;
    const listing = page.querySelector('div .car-listing-card');
    expect(listing).toBeTruthy();
  });
});
