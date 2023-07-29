import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './User_Interface/header/header.component';
import { FooterComponent } from './User_Interface/footer/footer.component';
import { DropdownUserComponent } from './User_Interface/dropdown-user/dropdown-user.component';
import { CarouselSliderComponent } from './User_Interface/TrangChu/Carousel-Slider.component';
import { TrangThucDonComponent } from './User_Interface/TrangThucDon/TrangThucDon.component';
import { DoiMauChuDirective } from './Directives/doi-mau-chu.directive';
import { MenuCategoryNavComponent } from './User_Interface/TrangThucDon/MenuCategoryNav/MenuCategoryNav.component';
import { ListMenuComponent } from './User_Interface/TrangThucDon/ListMenu/ListMenu.component';
import { TrangDangNhapComponent } from './User_Interface/TrangDangNhap/TrangDangNhap.component';
import { DangKyComponent } from './User_Interface/DangKy/DangKy.component';
import { TrangUuDaiComponent } from './User_Interface/TrangUuDai/TrangUuDai.component';
import { TrangChiTietUuDaiComponent } from './User_Interface/TrangChiTietUuDai/TrangChiTietUuDai.component';
import { CuaHangPopUpComponent } from './User_Interface/TrangChiTietUuDai/CuaHangPopUp/CuaHangPopUp.component';
import { DoiUuDaiPopUpComponent } from './User_Interface/TrangChiTietUuDai/DoiUuDaiPopUp/DoiUuDaiPopUp.component';
import { TrangTinTucComponent } from './User_Interface/TinTuc/TrangTinTuc/TrangTinTuc.component';
import { ChiTietTinTucComponent } from './User_Interface/TinTuc/ChiTietTinTuc/ChiTietTinTuc.component';
import { TrangGioHangComponent } from './User_Interface/TrangGioHang/TrangGioHang.component';
import { DatMonComponent } from './User_Interface/DatMon/DatMon.component';
import { DoiMauBtnDirective } from './Directives/DoiMauBtn.directive';
import { CuonTrangDirective } from './Directives/CuonDenIdCate/CuonTrang.directive';
import { GiaoDienCaNhanComponent } from './User_Interface/GiaoDienCaNhan/GiaoDienCaNhan.component';
import { ThongTinCaNhanComponent } from './User_Interface/GiaoDienCaNhan/ThongTinCaNhan/ThongTinCaNhan.component';
import { UuDaiCuaToiComponent } from './User_Interface/GiaoDienCaNhan/UuDaiCuaToi/UuDaiCuaToi.component';
import { SoDiaChiComponent } from './User_Interface/GiaoDienCaNhan/SoDiaChi/SoDiaChi.component';
import { LichSuDatBanComponent } from './User_Interface/GiaoDienCaNhan/LichSuDatBan/LichSuDatBan.component';
import { LichSuGiaoHangComponent } from './User_Interface/GiaoDienCaNhan/LichSuGiaoHang/LichSuGiaoHang.component';
import { ChiTietLSDatHangComponent } from './User_Interface/GiaoDienCaNhan/ChiTietLSDatHang/ChiTietLSDatHang.component';
import { ThemDiaChiPopUpComponent } from './User_Interface/GiaoDienCaNhan/SoDiaChi/ThemDiaChiPopUp/ThemDiaChiPopUp.component';
import { TrangDatBanComponent } from './User_Interface/TrangDatBan/TrangDatBan.component';
import { ChiTietDatBanComponent } from './User_Interface/ChiTietDatBan/ChiTietDatBan.component';
import { XacNhanPopUpComponent } from './User_Interface/ChiTietDatBan/XacNhanPopUp/XacNhanPopUp.component';
import { TrangThanhToanComponent } from './User_Interface/TrangThanhToan/TrangThanhToan.component';
import { TrangDoiMatKhauComponent } from './User_Interface/TrangDoiMatKhau/TrangDoiMatKhau.component';
import { HomeAdminComponent } from './Admin_Interface/home-admin/home-admin.component';
import { CRUDMenuComponent } from './Admin_Interface/CRUDMenu/CRUDMenu.component';
import { CRUDMenuCategoryComponent } from './Admin_Interface/CRUDMenuCategory/CRUDMenuCategory.component';
import { CRUDNewsComponent } from './Admin_Interface/CRUDNews/CRUDNews.component';
import { ThemThucDonPopUpComponent } from './Admin_Interface/CRUDMenu/ThemThucDonPopUp/ThemThucDonPopUp.component';
import { SuaThucDonPopUpComponent } from './Admin_Interface/CRUDMenu/SuaThucDonPopUp/SuaThucDonPopUp.component';
import { MenuService } from './Services/MenuService/Menu.service';
import { MenuCategoryService } from './Services/MenuCategoryService/MenuCategory.service';
import { FormsModule } from '@angular/forms';
import { PaginationComponent } from './Admin_Interface/CRUDMenu/Pagination/Pagination.component';








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
    ThemDiaChiPopUpComponent,
    TrangDatBanComponent,
    ChiTietDatBanComponent,
    XacNhanPopUpComponent,
    TrangThanhToanComponent,
    TrangDoiMatKhauComponent,
    HomeAdminComponent,
    CRUDMenuComponent,
    CRUDMenuCategoryComponent,
    CRUDNewsComponent,
    ThemThucDonPopUpComponent,
    SuaThucDonPopUpComponent,
    PaginationComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    MenuService,
    MenuCategoryService

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
