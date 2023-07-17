import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ChiTietDatBan',
  templateUrl: './ChiTietDatBan.component.html',
  styleUrls: ['./ChiTietDatBan.component.css']
})
export class ChiTietDatBanComponent implements OnInit {

  public istaikhoan:boolean = false;
  public isshowpopup:boolean = false;
  constructor() { }

  ngOnInit() {
  }
  public chuyendoi(){
    this.istaikhoan = !this.istaikhoan;
  }
  public showhidepop(){
        this.isshowpopup = !this.isshowpopup;
  }
}
