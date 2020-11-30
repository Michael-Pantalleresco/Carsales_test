import {Component, OnInit} from '@angular/core';
import {Advert} from '../models/advert';
import {ApiAdvertService} from '../services/api-advert.service';

@Component({
  selector: 'app-adverts',
  templateUrl: './adverts.component.html',
  styleUrls: ['./adverts.component.css'],
  providers: [
    ApiAdvertService
  ]
})
export class AdvertsComponent implements OnInit{
  adverts: Advert[];
  constructor(private advertsService: ApiAdvertService) {
  }

  ngOnInit(): void {
    this.advertsService.getAdverts()
      .subscribe(result =>
        this.adverts = result);
  }

}


