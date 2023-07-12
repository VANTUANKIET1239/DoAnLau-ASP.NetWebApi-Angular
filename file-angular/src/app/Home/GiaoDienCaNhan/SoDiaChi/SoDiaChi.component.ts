import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-SoDiaChi',
  templateUrl: './SoDiaChi.component.html',
  styleUrls: ['./SoDiaChi.component.css']
})
export class SoDiaChiComponent implements OnInit {

  constructor() { }
  public ispopup: boolean = false;
  public isScrollLocked:boolean = false;
  ngOnInit() {
  }

  public showpopup(){
    this.ispopup = !this.ispopup;
    this.lockScroll(this.ispopup);
  }
  public lockScroll(ispopup:boolean) {
    this.isScrollLocked = ispopup;
    if(ispopup){
      document.body.style.overflow = 'hidden';
    }
    else{
      document.body.style.overflow = '';
    }
  }
  
  
}
