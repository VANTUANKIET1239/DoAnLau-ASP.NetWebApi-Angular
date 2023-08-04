import { MenuService } from 'src/app/Services/MenuService/Menu.service';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Menu } from 'src/app/Models/Menu';
import { Router } from '@angular/router';
import { MenuCategory } from 'src/app/Models/MenuCategory';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';

@Component({
  selector: 'app-XacNhanXoaDMTD',
  templateUrl: './XacNhanXoaDMTD.component.html',
  styleUrls: ['./XacNhanXoaDMTD.component.css']
})
export class XacNhanXoaDMTDComponent implements OnInit {

  @Output() public hideshowOutputRemoveConfirm = new EventEmitter();
  @Input() public removeItemData:MenuCategory = new MenuCategory('','',true);
  constructor(private menuCategoryService: MenuCategoryService,private router: Router) { }
  ngOnInit() {
  }
  public HideorShowPopup(){
      this.hideshowOutputRemoveConfirm.emit();
  }
  public RemoveMenu(){
      this.menuCategoryService.RemoveMenuCategory(this.removeItemData).subscribe((data) => {
          if(data.success){
              alert("Xóa danh mục thực đơn thành công !");
          };
          this.HideorShowPopup();
          this.LoadComponent();
      });
  }
  public LoadComponent(){
    window.location.reload();
  }

}
