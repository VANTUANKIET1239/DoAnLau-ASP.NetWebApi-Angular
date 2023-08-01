import { MenuService } from 'src/app/Services/MenuService/Menu.service';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Menu } from 'src/app/Models/Menu';
import { Router } from '@angular/router';

@Component({
  selector: 'app-XacNhanXoaPopUp',
  templateUrl: './XacNhanXoaPopUp.component.html',
  styleUrls: ['./XacNhanXoaPopUp.component.css']
})
export class XacNhanXoaPopUpComponent implements OnInit {


  @Output() public hideshowOutputRemoveConfirm = new EventEmitter();
  @Input() public removeItemData:Menu = new Menu('','','',0,true,true,true);
  constructor(private menuService: MenuService,private router: Router) { }
  ngOnInit() {
  }
  public HideorShowPopup(){
      this.hideshowOutputRemoveConfirm.emit();
  }
  public RemoveMenu(){
      console.log(<string>this.removeItemData?.menu_Id);
      this.menuService.RemoveMenu(this.removeItemData).subscribe((data) => {
          if(data.success){
              alert("Xóa thực đơn thành công !");
          };
          this.HideorShowPopup();
          this.LoadComponent();
      });
  }
  public LoadComponent(){
    window.location.reload();
  }

}
