import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-DatMon',
  templateUrl: './DatMon.component.html',
  styleUrls: ['./DatMon.component.css']
})
export class DatMonComponent implements OnInit {

  public quantity:number = 0;
  public haveQuantity:boolean = false;
  constructor() { }

  ngOnInit() {
  }
  public GiamSL(){
      if(this.quantity > 1){
          this.quantity -= 1;
      }
      else if(this.quantity == 1){
          this.quantity -= 1;
          this.haveQuantity = false;
      }
  }
  public TangSL(){
      this.quantity += 1;
        if(this.quantity > 0){          
          this.haveQuantity = true;
      }
     
  }
}
