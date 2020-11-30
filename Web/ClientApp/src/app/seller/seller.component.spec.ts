import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SellerComponent } from './seller.component';
import {DebugElement} from '@angular/core';

describe('SellerComponent', () => {
  let component: SellerComponent;
  let fixture: ComponentFixture<SellerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SellerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SellerComponent);
    component = fixture.componentInstance;
    component.seller = {
      firstName: 'John',
      surname: 'Smith',
      phoneNumber: '123456'
    };
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render seller details', () => {
    const debugElement: DebugElement = fixture.debugElement;
    const page: HTMLElement = debugElement.nativeElement;
    const list = page.querySelector('div .seller-details>ul');
    expect(list).toBeTruthy();
  });
});
