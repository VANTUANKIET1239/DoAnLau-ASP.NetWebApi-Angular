import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Home/header/header.component';
import { FooterComponent } from './Home/footer/footer.component';
import { DropdownUserComponent } from './Home/dropdown-user/dropdown-user.component';
import { CarouselSliderComponent } from './Home/TrangChu/Carousel-Slider.component';
import { TrangThucDonComponent } from './Home/TrangThucDon/TrangThucDon.component';
import { DoiMauChuDirective } from './Directives/doi-mau-chu.directive';
import { MenuCategoryNavComponent } from './Home/TrangThucDon/MenuCategoryNav/MenuCategoryNav.component';
import { ListMenuComponent } from './Home/TrangThucDon/ListMenu/ListMenu.component';
import { TrangDangNhapComponent } from './Home/TrangDangNhap/TrangDangNhap.component';
import { DangKyComponent } from './Home/DangKy/DangKy.component';
import { TrangUuDaiComponent } from './Home/TrangUuDai/TrangUuDai.component';
import { TrangChiTietUuDaiComponent } from './Home/TrangChiTietUuDai/TrangChiTietUuDai.component';
import { CuaHangPopUpComponent } from './Home/TrangChiTietUuDai/CuaHangPopUp/CuaHangPopUp.component';





@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    DropdownUserComponent,
    CarouselSliderComponent,
    TrangThucDonComponent,
    DoiMauChuDirective,
    MenuCategoryNavComponent,
    ListMenuComponent,
    TrangDangNhapComponent,
    DangKyComponent,
    TrangUuDaiComponent,
    TrangChiTietUuDaiComponent,
    CuaHangPopUpComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
