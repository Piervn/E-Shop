import { Injectable, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BasketService {
  counter: number = 0;
  counterChanged: EventEmitter<number> = new EventEmitter();

  incrementCounter() {
    this.counter++;
    this.counterChanged.emit(this.counter);
  }
  
  constructor() { }
}
