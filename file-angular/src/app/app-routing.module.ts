import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarouselSliderComponent } from './User_Interface/TrangChu/Carousel-Slider.component';
import { TrangThucDonComponent } from './User_Interface/TrangThucDon/TrangThucDon.component';
import { TrangDangNhapComponent } from './User_Interface/TrangDangNhap/TrangDangNhap.component';
import { DangKyComponent } from './User_Interface/DangKy/DangKy.component';
import { TrangUuDaiComponent } from './User_Interface/TrangUuDai/TrangUuDai.component';
import { TrangChiTietUuDaiComponent } from './User_Interface/TrangChiTietUuDai/TrangChiTietUuDai.component';
import { TrangTinTucComponent } from './User_Interface/TinTuc/TrangTinTuc/TrangTinTuc.component';
import { ChiTietTinTucComponent } from './User_Interface/TinTuc/ChiTietTinTuc/ChiTietTinTuc.component';
import { TrangGioHangComponent } from './User_Interface/TrangGioHang/TrangGioHang.component';
import { DatMonComponent } from './User_Interface/DatMon/DatMon.component';
import { GiaoDienCaNhanComponent } from './User_Interface/GiaoDienCaNhan/GiaoDienCaNhan.component';
import { ThongTinCaNhanComponent } from './User_Interface/GiaoDienCaNhan/ThongTinCaNhan/ThongTinCaNhan.component';
import { UuDaiCuaToiComponent } from './User_Interface/GiaoDienCaNhan/UuDaiCuaToi/UuDaiCuaToi.component';
import { SoDiaChiComponent } from './User_Interface/GiaoDienCaNhan/SoDiaChi/SoDiaChi.component';
import { LichSuGiaoHangComponent } from './User_Interface/GiaoDienCaNhan/LichSuGiaoHang/LichSuGiaoHang.component';
import { LichSuDatBanComponent } from './User_Interface/GiaoDienCaNhan/LichSuDatBan/LichSuDatBan.component';
import { ChiTietLSDatHangComponent } from './User_Interface/GiaoDienCaNhan/ChiTietLSDatHang/ChiTietLSDatHang.component';
import { TrangDatBanComponent } from './User_Interface/TrangDatBan/TrangDatBan.component';
import { ChiTietDatBanComponent } from './User_Interface/ChiTietDatBan/ChiTietDatBan.component';
import { HomeAdminComponent } from './Admin_Interface/home-admin/home-admin.component';
import { CRUDNewsComponent } from './Admin_Interface/CRUDNews/CRUDNews.component';
import { CRUDMenuComponent } from './Admin_Interface/CRUDMenu/CRUDMenu.component';
import { CRUDMenuCategoryComponent } from './Admin_Interface/CRUDMenuCategory/CRUDMenuCategory.component';


const routes: Routes = [
  {path:'TrangChu', component:CarouselSliderComponent,pathMatch:'full' },
  {path:'ThucDon', component:TrangThucDonComponent,pathMatch:'full' },
  {path:'DangNhap', component:TrangDangNhapComponent,pathMatch:'full' },
  {path:'DangKy', component:DangKyComponent,pathMatch:'full' },
  {path:'TinTuc', component:TrangTinTucComponent,pathMatch:'full' },
  {path:'ChiTietTinTuc', component:ChiTietTinTucComponent },
  {path:'DatMon', component:DatMonComponent,pathMatch:'full' },
  {path:'DatBan', component:TrangDatBanComponent,pathMatch:'full' },
  {path:'ChiTietDatBan', component:ChiTietDatBanComponent,pathMatch:'full' },
  {path:'Admin', component:HomeAdminComponent,
  children:[
    {path:'CRUDNews/:name', component:CRUDNewsComponent},
    {path:'CRUDMenu/:name', component:CRUDMenuComponent},
    {path:'CRUDMenuCategory/:name', component:CRUDMenuCategoryComponent},
  ]

  },
  {path:'User', component:GiaoDienCaNhanComponent,
    children:[
    {path:'ThongTinCaNhan', component:ThongTinCaNhanComponent },
    {path:'UuDaiCuaToi', component:UuDaiCuaToiComponent },
    {path:'LichSuGiaoHang', component:LichSuGiaoHangComponent },
    {path:'LichSuDatBan', component:LichSuDatBanComponent },
    {path:'SoDiaChi', component:SoDiaChiComponent },
    ]
  },
  {path:'UuDai', component:TrangUuDaiComponent,pathMatch:'full' },
  {path:'ChiTietGiaoHang', component:ChiTietLSDatHangComponent,pathMatch:'full' },
  {path:'GioHang', component:TrangGioHangComponent,pathMatch:'full' },
  {path:'ChiTietUuDai', component:TrangChiTietUuDaiComponent,pathMatch:'full' },
  {path:'**', component:CarouselSliderComponent,pathMatch:'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
   declarations: [

  ]
})
export class AppRoutingModule { }
