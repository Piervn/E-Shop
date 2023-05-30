import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { BasketService } from './basket.service';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CategoryMenuComponent } from './category-menu/category-menu.component';
import { HomeComponent } from './home/home.component';
import { BasketComponent } from './basket/basket.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProductComponent } from './product/product.component';
import { ProductListComponent } from './product-list/product-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    CategoryMenuComponent,
    HomeComponent,
    BasketComponent,
    CounterComponent,
    FetchDataComponent,
    ProductComponent,
    ProductListComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'basket', component: BasketComponent },
    ]),
  ],
  providers: [
    BasketService,
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
