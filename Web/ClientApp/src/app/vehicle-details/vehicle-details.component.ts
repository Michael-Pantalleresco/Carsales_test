import {Component, Input, OnInit} from '@angular/core';
import {Detail} from '../models/detail';
import {ApiDetailsService} from '../services/api-details.service';
import { Router} from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './vehicle-details.component.html',
  styleUrls: ['./vehicle-details.component.css', './../adverts/adverts.component.css' , './../car-listing/car-listing.component.css'],
  providers: [ApiDetailsService]
})
export class DetailsComponent implements OnInit {
  @Input() vehicle: Detail;
  constructor(private apiDetailsService: ApiDetailsService, private router: Router) { }
  advertId: string = this.getAdvertId(this.getUrlParts());
  ngOnInit(): void {
    this.apiDetailsService.GetDetails(this.advertId).subscribe(result => {
      this.vehicle = result;
    });
  }

  getUrlParts(): string[] {
    return this.router.url.split('/');
  }

  getAdvertId(urlParts: string[]): string{
    return urlParts[urlParts.length - 1];
  }
}
