import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarouselSliderComponent } from './Home/TrangChu/Carousel-Slider.component';
import { TrangThucDonComponent } from './Home/TrangThucDon/TrangThucDon.component';
import { TrangDangNhapComponent } from './Home/TrangDangNhap/TrangDangNhap.component';
import { DangKyComponent } from './Home/DangKy/DangKy.component';
import { TrangUuDaiComponent } from './Home/TrangUuDai/TrangUuDai.component';
import { TrangChiTietUuDaiComponent } from './Home/TrangChiTietUuDai/TrangChiTietUuDai.component';
import { TrangTinTucComponent } from './Home/TinTuc/TrangTinTuc/TrangTinTuc.component';
import { ChiTietTinTucComponent } from './Home/TinTuc/ChiTietTinTuc/ChiTietTinTuc.component';
import { TrangGioHangComponent } from './Home/TrangGioHang/TrangGioHang.component';
import { DatMonComponent } from './Home/DatMon/DatMon.component';
import { GiaoDienCaNhanComponent } from './Home/GiaoDienCaNhan/GiaoDienCaNhan.component';
import { ThongTinCaNhanComponent } from './Home/GiaoDienCaNhan/ThongTinCaNhan/ThongTinCaNhan.component';
import { UuDaiCuaToiComponent } from './Home/GiaoDienCaNhan/UuDaiCuaToi/UuDaiCuaToi.component';
import { SoDiaChiComponent } from './Home/GiaoDienCaNhan/SoDiaChi/SoDiaChi.component';
import { LichSuGiaoHangComponent } from './Home/GiaoDienCaNhan/LichSuGiaoHang/LichSuGiaoHang.component';
import { LichSuDatBanComponent } from './Home/GiaoDienCaNhan/LichSuDatBan/LichSuDatBan.component';
import { ChiTietLSDatHangComponent } from './Home/GiaoDienCaNhan/ChiTietLSDatHang/ChiTietLSDatHang.component';
import { TrangDatBanComponent } from './Home/TrangDatBan/TrangDatBan.component';


const routes: Routes = [
  {path:'TrangChu', component:CarouselSliderComponent,pathMatch:'full' },
  {path:'ThucDon', component:TrangThucDonComponent,pathMatch:'full' },
  {path:'DangNhap', component:TrangDangNhapComponent,pathMatch:'full' },
  {path:'DangKy', component:DangKyComponent,pathMatch:'full' },
  {path:'TinTuc', component:TrangTinTucComponent,pathMatch:'full' },
  {path:'ChiTietTinTuc', component:ChiTietTinTucComponent },
  {path:'DatMon', component:DatMonComponent,pathMatch:'full' },
  {path:'DatBan', component:TrangDatBanComponent,pathMatch:'full' },
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
