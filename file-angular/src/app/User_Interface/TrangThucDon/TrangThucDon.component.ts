import { MenuCategory } from './../../Models/MenuCategory';
import { Component, OnInit } from '@angular/core';
import { Menu } from 'src/app/Models/Menu';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';
import { MenuService } from 'src/app/Services/MenuService/Menu.service';

@Component({
  selector: 'app-TrangThucDon',
  templateUrl: './TrangThucDon.component.html',
  styleUrls: ['./TrangThucDon.component.css']
})
export class TrangThucDonComponent implements OnInit {

  constructor
  (private menuCategoryService: MenuCategoryService,
    private menuService: MenuService
  )
   {
      this.GetItemsMenuCategories();
   }
  public listMenuCateItems: MenuCategory[] = [];
  public listMenuItems: Menu[] = [];
  ngOnInit() {

  }
  public GetItemsMenuCategories(){
      this.menuCategoryService.GetMenuCategories().subscribe((response) => {
          this.listMenuCateItems = response;
      });
  }
  public onChangeListMenuItems(event: string){
        let menuCateId:string = event;
        this.menuService.GetMenusByCate(menuCateId).subscribe((response) => {
            this.listMenuItems = response;
        });

  }

}
