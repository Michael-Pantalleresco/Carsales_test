import {Component, Input, OnInit} from '@angular/core';
import {Seller} from '../models/seller';

@Component({
  selector: 'app-seller',
  templateUrl: './seller.component.html',
  styleUrls: ['./seller.component.css']
})
export class SellerComponent implements OnInit {
  @Input() seller: Seller;
  constructor() { }

  ngOnInit(): void {
  }

}
