import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-TrangChiTietUuDai',
  templateUrl: './TrangChiTietUuDai.component.html',
  styleUrls: ['./TrangChiTietUuDai.component.css']
})
export class TrangChiTietUuDaiComponent implements OnInit {

  constructor() { }
  public ispopupCH = false;
  public ispopupUuDai = false;
  public isScrollLocked = false;
  
  ngOnInit() {
  }
  public popupCH(nd:string){
    if(nd == "CH"){
      this.ispopupCH = true;
      this.lockScroll();
     }
     else {
      this.ispopupUuDai = true;
      this.lockScroll();
     }     
  }
  public popupCHhide(nd:string){     
       if(nd == "CH"){
        this.ispopupCH = false;
        this.unlockScroll();
       }
       else {
        this.ispopupUuDai = false;
        this.unlockScroll();
       }          
  }
  public lockScroll() {
    this.isScrollLocked = true;
    document.body.style.overflow = 'hidden';
  }
  
  public unlockScroll() {
    this.isScrollLocked = false;
    document.body.style.overflow = '';
  }
}
