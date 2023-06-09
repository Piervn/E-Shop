import { Component } from '@angular/core';
import { BasketService } from '../basket.service';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.css']
})
export class BasketComponent {
  constructor(private basketService: BasketService) { }

  incrementCounter() {
    this.basketService.incrementCounter();
  }
}
