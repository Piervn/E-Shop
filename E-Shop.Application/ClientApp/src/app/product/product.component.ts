import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css'],
  inputs: ['producttt'],
})
export class ProductComponent implements OnInit {
  product: Product = {
    id: 1,
    name: 'Phone XL',
    price: 799,
    description: 'A large phone with one of the best screens',
    image:
      'https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/9/pr_2022_9_9_9_30_25_22_03.jpg',
  };
  constructor() {}

  ngOnInit(): void {}
}

export interface Product {
  id: number;
  name: string;
  price: number;
  description: string;
  image: string;
}
