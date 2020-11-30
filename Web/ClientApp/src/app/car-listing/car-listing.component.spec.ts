import {ComponentFixture, TestBed} from '@angular/core/testing';
import {CarListingComponent} from './car-listing.component';
import {DebugElement} from '@angular/core';

describe('CarListingComponent', () => {
  let component: CarListingComponent;
  let fixture: ComponentFixture<CarListingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarListingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarListingComponent);
    component = fixture.componentInstance;
    component.listing =
      {
        advertId: '123',
        memberId: '',
        heroImage: 'car.jpeg',
        price: 100,
        vertical: 'Car',
        dateLastUpdated: new Date(),
        dateCreated: new Date(),
        title: 'Title'
      };
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render the title', () => {
    const debugElement: DebugElement = fixture.debugElement;
    const page: HTMLElement = debugElement.nativeElement;
    const title = page.querySelector('div .car-listing-title');
    expect(title).toBeTruthy();
    expect(title.className).toContain('col-6');
  });

  it('should render the price', () => {
    const debugElement: DebugElement = fixture.debugElement;
    const page: HTMLElement = debugElement.nativeElement;
    const price = page.querySelector('div .car-listing-price');
    expect(price).toBeTruthy();
    expect(price.className).toContain('col-6');
  });

  it('should render the image', () => {
    const debugElement: DebugElement = fixture.debugElement;
    const page = debugElement.nativeElement;
    const image = page.querySelector('div.car-listing-image>img');
    expect(image).toBeTruthy();
  });

  it('should render the details list', () => {
    const debugElement: DebugElement = fixture.debugElement;
    const page = debugElement.nativeElement;
    const details = page.querySelector('div .car-listing-details');
    const list = details.querySelector('.car-listing-details-list');
    expect(list).toBeTruthy();
    expect(list.innerHTML).toContain('li');
  });
});
