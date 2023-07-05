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


const routes: Routes = [
  {path:'TrangChu', component:CarouselSliderComponent,pathMatch:'full' },
  {path:'ThucDon', component:TrangThucDonComponent,pathMatch:'full' },
  {path:'DangNhap', component:TrangDangNhapComponent,pathMatch:'full' },
  {path:'DangKy', component:DangKyComponent,pathMatch:'full' },
  {path:'TinTuc', component:TrangTinTucComponent,pathMatch:'full' },
  {path:'ChiTietTinTuc', component:ChiTietTinTucComponent },
  {path:'DatMon', component:DatMonComponent },
  {path:'UuDai', component:TrangUuDaiComponent,pathMatch:'full' },
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
