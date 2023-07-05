import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-CuaHangPopUp',
  templateUrl: './CuaHangPopUp.component.html',
  styleUrls: ['./CuaHangPopUp.component.css']
})
export class CuaHangPopUpComponent implements OnInit {

  constructor() { }
  @Output() public hidepop = new EventEmitter();
  ngOnInit() {
  }
  public hidepopup(){
      this.hidepop.emit();
  }
}
