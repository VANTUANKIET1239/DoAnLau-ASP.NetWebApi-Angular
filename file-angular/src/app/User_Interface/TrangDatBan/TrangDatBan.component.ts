import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-TrangDatBan',
  templateUrl: './TrangDatBan.component.html',
  styleUrls: ['./TrangDatBan.component.css']
})
export class TrangDatBanComponent implements OnInit {

  public istaikhoan:boolean = false;
  constructor() { }

  ngOnInit() {
  }
  public chuyendoi(){
    this.istaikhoan = !this.istaikhoan;
  }
}
