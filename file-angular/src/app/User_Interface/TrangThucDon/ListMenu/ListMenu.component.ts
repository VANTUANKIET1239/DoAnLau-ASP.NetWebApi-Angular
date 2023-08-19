import { Component, Input, OnInit } from '@angular/core';
import { Menu } from 'src/app/Models/Menu';
import { MenuService } from 'src/app/Services/MenuService/Menu.service';

@Component({
  selector: 'app-ListMenu',
  templateUrl: './ListMenu.component.html',
  styleUrls: ['./ListMenu.component.css']
})
export class ListMenuComponent implements OnInit {

  constructor(
    private menuService: MenuService
  ) {
    this.GetAllMenuItems();
  }
  @Input() public listMenuItems:Menu[] = [];
  ngOnInit() {

  }
  public GetAllMenuItems():void{
      this.menuService.GetMenus().subscribe((response) => {
        this.listMenuItems = response;
      });
  }

}
