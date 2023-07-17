import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-XacNhanPopUp',
  templateUrl: './XacNhanPopUp.component.html',
  styleUrls: ['./XacNhanPopUp.component.css']
})
export class XacNhanPopUpComponent implements OnInit {

  @Output() public hideorshow = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }
  public hideorshowpopup(){
      this.hideorshow.emit();
  }
}
