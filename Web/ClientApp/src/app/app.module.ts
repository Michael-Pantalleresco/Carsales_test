import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdvertsComponent } from './adverts/adverts.component';
import { HttpClientModule } from '@angular/common/http';
import { DetailsComponent } from './vehicle-details/vehicle-details.component';
import { CarListingComponent } from './car-listing/car-listing.component';
import {MockAdvertsService} from './services/mock-adverts.service';
import { SellerComponent } from './seller/seller.component';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CommentsComponent } from './comments/comments.component';
import { ButtonComponent } from './button/button.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {ApiAdvertService} from './services/api-advert.service';

@NgModule({
  declarations: [
    AppComponent,
    AdvertsComponent,
    DetailsComponent,
    CarListingComponent,
    SellerComponent,
    CommentsComponent,
    ButtonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FontAwesomeModule,
    NgbModule
  ],
  providers: [
    { provide: ApiAdvertService, useClass: MockAdvertsService }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
