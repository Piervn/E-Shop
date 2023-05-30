import { Component, OnInit } from '@angular/core';
import { Product } from '../product/product.component';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
})
export class ProductListComponent implements OnInit {
  products: Product[] = [
    {
      id: 1,
      name: 'Phone XL',
      price: 799,
      description: 'A large phone with one of the best screens',
      image:
        'https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/9/pr_2022_9_9_9_30_25_22_03.jpg',
    },
    {
      id: 2,
      name: 'Phone Mini',
      price: 699,
      description: 'A great phone with one of the best cameras',
      image:
        'https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/9/pr_2022_9_9_9_30_25_22_03.jpg',
    },
    {
      id: 3,
      name: 'Phone Standard',
      price: 299,
      description: '',
      image:
        'https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/9/pr_2022_9_9_9_30_25_22_03.jpg',
    }
  ];
  constructor() {}

  ngOnInit(): void {}
}
