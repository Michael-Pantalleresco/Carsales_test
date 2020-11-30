import {Component, Input, OnInit} from '@angular/core';
import {Advert} from '../models/advert';

@Component({
  selector: 'app-car-listing',
  templateUrl: './car-listing.component.html',
  styleUrls: ['./car-listing.component.css'],
})
export class CarListingComponent implements OnInit {
  @Input() listing: Advert;
  constructor() {
  }

  ngOnInit(): void {
  }

}

