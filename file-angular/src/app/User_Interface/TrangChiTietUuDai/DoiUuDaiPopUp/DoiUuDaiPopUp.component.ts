import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-DoiUuDaiPopUp',
  templateUrl: './DoiUuDaiPopUp.component.html',
  styleUrls: ['./DoiUuDaiPopUp.component.css']
})
export class DoiUuDaiPopUpComponent implements OnInit {

  constructor() { }

  @Output() public hidepop = new EventEmitter();
  ngOnInit() {
  }
  public hidepopup(){
      this.hidepop.emit();
  }
}
