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
import { DoiUuDaiPopUpComponent } from './Home/TrangChiTietUuDai/DoiUuDaiPopUp/DoiUuDaiPopUp.component';
import { TrangTinTucComponent } from './Home/TinTuc/TrangTinTuc/TrangTinTuc.component';
import { ChiTietTinTucComponent } from './Home/TinTuc/ChiTietTinTuc/ChiTietTinTuc.component';
import { TrangGioHangComponent } from './Home/TrangGioHang/TrangGioHang.component';
import { DatMonComponent } from './Home/DatMon/DatMon.component';
import { DoiMauBtnDirective } from './Directives/DoiMauBtn.directive';
import { CuonTrangDirective } from './Directives/CuonDenIdCate/CuonTrang.directive';
import { GiaoDienCaNhanComponent } from './Home/GiaoDienCaNhan/GiaoDienCaNhan.component';
import { ThongTinCaNhanComponent } from './Home/GiaoDienCaNhan/ThongTinCaNhan/ThongTinCaNhan.component';
import { UuDaiCuaToiComponent } from './Home/GiaoDienCaNhan/UuDaiCuaToi/UuDaiCuaToi.component';
import { SoDiaChiComponent } from './Home/GiaoDienCaNhan/SoDiaChi/SoDiaChi.component';
import { LichSuDatBanComponent } from './Home/GiaoDienCaNhan/LichSuDatBan/LichSuDatBan.component';
import { LichSuGiaoHangComponent } from './Home/GiaoDienCaNhan/LichSuGiaoHang/LichSuGiaoHang.component';
import { ChiTietLSDatHangComponent } from './Home/GiaoDienCaNhan/ChiTietLSDatHang/ChiTietLSDatHang.component';
import { ThemDiaChiPopUpComponent } from './Home/GiaoDienCaNhan/SoDiaChi/ThemDiaChiPopUp/ThemDiaChiPopUp.component';






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
    CuaHangPopUpComponent,
    DoiUuDaiPopUpComponent,
    TrangTinTucComponent,
    ChiTietTinTucComponent,
    TrangGioHangComponent,
    DatMonComponent,
    DoiMauBtnDirective,
    CuonTrangDirective,
    GiaoDienCaNhanComponent,
    ThongTinCaNhanComponent,
    UuDaiCuaToiComponent,
    SoDiaChiComponent,
    LichSuDatBanComponent,
    LichSuGiaoHangComponent,
    ChiTietLSDatHangComponent,
    ThemDiaChiPopUpComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
