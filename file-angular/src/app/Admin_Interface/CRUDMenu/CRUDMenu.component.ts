import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-CRUDMenu',
  templateUrl: './CRUDMenu.component.html',
  styleUrls: ['./CRUDMenu.component.css']
})
export class CRUDMenuComponent implements OnInit {
  public categoryName: string = "";
  constructor(private route:ActivatedRoute) { }
  public popupconditions:boolean = false;
  ngOnInit() {
    this.categoryName = <string> this.route.snapshot.paramMap.get("name");
  }
  public ShowHidePopUpMenu(){
    this.popupconditions = !this.popupconditions;
  }

}
