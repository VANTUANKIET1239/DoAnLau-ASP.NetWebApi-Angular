import { MenuService } from './../../Services/MenuService/Menu.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Menu } from 'src/app/Models/Menu';
import { MenuCategory } from 'src/app/Models/MenuCategory';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';

@Component({

  selector: 'app-CRUDMenu',
  templateUrl: './CRUDMenu.component.html',
  styleUrls: ['./CRUDMenu.component.css']
})
export class CRUDMenuComponent implements OnInit {
  public categoryName: string = "";
  public menus: Menu[] = [];
  public menusview:Menu[] = [];
  public menucategories: MenuCategory[] = [];
  public selectedcategory:string = '';


  constructor(private route:ActivatedRoute,
              private menuService: MenuService,
              private menucategoryservice: MenuCategoryService) { }
  public popupconditions:boolean = false;
  ngOnInit() {
    this.categoryName = <string> this.route.snapshot.paramMap.get("name");
    this.menuService.GetMenus().subscribe((data) =>{
       // this.menus.push(...data);
       this.menus = data;
       this.menusview = this.menus;
    });
    this.menucategoryservice.GetMenuCategories().subscribe((data) => {
      this.menucategories = data;
    });

  }
  public ShowHidePopUpMenu(){
    this.popupconditions = !this.popupconditions;
  }

  public selectedCate(selectedcategoryid:string){
      if(selectedcategoryid == "TB"){
         this.menusview = this.menus;
      }
      else{
        this.menuService.GetMenusByCate(selectedcategoryid).subscribe((data) => {
          this.menusview = data;
        });

      }
  }

  public SearchMenu(content:string){
     var contentuppdercase = content.toUpperCase();
       this.menusview = this.menus.filter(x => x.menuName.toUpperCase().includes(contentuppdercase));
  }




}
