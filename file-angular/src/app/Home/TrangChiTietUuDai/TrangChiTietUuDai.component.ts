import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-TrangChiTietUuDai',
  templateUrl: './TrangChiTietUuDai.component.html',
  styleUrls: ['./TrangChiTietUuDai.component.css']
})
export class TrangChiTietUuDaiComponent implements OnInit {

  constructor() { }
  public ispopup = false;
  public isScrollLocked = false;
  ngOnInit() {
  }
  public popupCH(){
    this.ispopup = true;
    this.lockScroll();
  }
  public popupCHhide(){     
        this.ispopup = false;
        this.unlockScroll();          
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
