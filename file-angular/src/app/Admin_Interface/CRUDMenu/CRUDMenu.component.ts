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
  public menusPage: Menu[] = [];
  public menusview:Menu[] = [];
  public menucategories: MenuCategory[] = [];
  public selectedcategory:string = '';
  public pageIndex:number = 1;
  public pageSize:number = 4;
  public totalCount: number = 0;

  constructor(private route:ActivatedRoute,
              private menuService: MenuService,
              private menucategoryservice: MenuCategoryService) { }
  public popupconditions:boolean = false;
  ngOnInit() {
    this.categoryName = <string> this.route.snapshot.paramMap.get("name");
    this.menuService.GetMenus().subscribe((data) =>{
      // this.menus.push(...data);
       this.menus = data;
       this.Pagination(this.menus);
    });
    this.menucategoryservice.GetMenuCategories().subscribe((data) => {
      this.menucategories = data;
    });

  }
  public Pagination(listitem:Menu[]){
      let newitem:Menu[] = [];
      let count = 0;
      this.menusPage = listitem;
      for(let i = (this.pageIndex - 1) * this.pageSize; i < listitem.length; i++){
        if(count == this.pageSize){
            break;
        }
        newitem.push(listitem[i]);
        count++;

     }
     this.totalCount = this.menusPage.length;
      this.menusview = newitem;

  }
  public ChangePage(event:any):void{
      this.pageIndex = event;
      this.Pagination(this.menusPage);
  }

  public ShowHidePopUpMenu(){
    this.popupconditions = !this.popupconditions;
  }

  public selectedCate(selectedcategoryid:string){
      if(selectedcategoryid == "TB"){
         this.Pagination(this.menus);
      }
      else{
        this.menuService.GetMenusByCate(selectedcategoryid).subscribe((data) => {
          this.pageIndex = 1;
          this.Pagination(data);
        });

      }
  }

  public SearchMenu(content:string){
     var contentuppdercase = content.toUpperCase();
     let searchlist:Menu[] = [];
     searchlist = this.menus.filter(x => x.menuName.toUpperCase().includes(contentuppdercase));
     this.pageIndex = 1;
     this.Pagination(searchlist);
  }




}
