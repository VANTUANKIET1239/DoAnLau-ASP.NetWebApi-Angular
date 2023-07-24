import { Component, ElementRef, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-ThemThucDonPopUp',
  templateUrl: './ThemThucDonPopUp.component.html',
  styleUrls: ['./ThemThucDonPopUp.component.css']
})
export class ThemThucDonPopUpComponent implements OnInit {
  public selectedImage: string  = '../../../assets/Image/default_image.jpg';
  @ViewChild("hinhanhmenu",{ static: false }) public elelinkimg!:ElementRef<HTMLInputElement>;
  @Output() public hideshowOutput = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }
  onLinkSelected() {
      this.selectedImage = this.elelinkimg.nativeElement.value;
  }
  public HideorShowPopup(){
      this.hideshowOutput.emit();
  }
}
