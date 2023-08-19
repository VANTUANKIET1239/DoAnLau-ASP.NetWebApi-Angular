import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MenuCategory } from 'src/app/Models/MenuCategory';

@Component({
  selector: 'app-MenuCategoryNav',
  templateUrl: './MenuCategoryNav.component.html',
  styleUrls: ['./MenuCategoryNav.component.css']
})
export class MenuCategoryNavComponent implements OnInit {

  constructor() { }
  @Input() public listMenuCateItems: MenuCategory[] = [];
  @Output() public onClick = new EventEmitter();
  ngOnInit() {
  }

  public onClickMenuItems(menuCateId: string){
      this.onClick.emit(menuCateId);
  }

}
