import { Component } from '@angular/core';
import { BasketService } from '../basket.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  counter = 0;

  constructor(private basketService: BasketService) {
    this.basketService.counterChanged.subscribe((value: number) => {
      this.counter = value;
    });
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

}
