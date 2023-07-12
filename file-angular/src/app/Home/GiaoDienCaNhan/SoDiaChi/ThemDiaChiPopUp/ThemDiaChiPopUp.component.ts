import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-ThemDiaChiPopUp',
  templateUrl: './ThemDiaChiPopUp.component.html',
  styleUrls: ['./ThemDiaChiPopUp.component.css']
})
export class ThemDiaChiPopUpComponent implements OnInit {

  constructor() { }
  @Output() public hidepop = new EventEmitter();
  ngOnInit() {
  }
  public hidepopup(){
      this.hidepop.emit();
  }
}
