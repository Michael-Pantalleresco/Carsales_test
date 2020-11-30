import {Observable} from 'rxjs';
import {Detail} from '../models/detail';

export interface DetailsService {
  GetDetails(advertId: string): Observable<Detail>;
}
