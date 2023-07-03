import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Home/header/header.component';
import { FooterComponent } from './Home/footer/footer.component';
import { DropdownUserComponent } from './Home/dropdown-user/dropdown-user.component';
import { CarouselSliderComponent } from './Home/main-content/TrangChu/Carousel-Slider.component';
import { MainContentComponent } from './Home/main-content/main-content.component';


@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    DropdownUserComponent,
    CarouselSliderComponent,
    MainContentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
