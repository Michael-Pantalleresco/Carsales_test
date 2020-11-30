import {Seller} from './seller';

interface Location {
  postcode: string;
  state: string;
  suburb: string;
  country: string;
}

export interface Photo {
  mediaId: string;
  secureUrl: string;
}

export interface Detail {
  advertId: string;
  memberId: string;
  heroImage: string;
  title: string;
  vertical: string;
  price: number;
  dateCreated: Date;
  dateLastUpdated: Date;
  odometer: number;
  colorInterior: string;
  colorExterior: string;
  registration: string;
  registrationExpiryMonth: number;
  registrationExpiryYear: number;
  make: string;
  model: string;
  year: number;
  comments: string;
  seller: Seller;
  location: Location;
  photos: Photo[];
}
