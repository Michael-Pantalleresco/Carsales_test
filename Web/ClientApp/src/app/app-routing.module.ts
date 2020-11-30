import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AdvertsComponent} from './adverts/adverts.component';
import {DetailsComponent} from './vehicle-details/vehicle-details.component';

const routes: Routes = [
  { path: 'adverts', component: AdvertsComponent },
  { path: 'details/:advertId', component: DetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
