import { Component, Input, OnInit } from '@angular/core';
import { BasketService } from '../basket.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css'],
})
export class ProductComponent implements OnInit {
  @Input()
  product!: Product;

  constructor(private basketService: BasketService) {}

  addToBasket(product: Product) {
    this.basketService.incrementCounter();
  }

  ngOnInit(): void {}
}

export interface Product {
  id: number;
  name: string;
  description: string;
  specification: string;
  category: string;
  price: number;
  review: number;
  quantity: number;
  image: string;
}
