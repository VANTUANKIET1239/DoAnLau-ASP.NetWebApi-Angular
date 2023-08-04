import { Component, ElementRef, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Menu } from 'src/app/Models/Menu';
import { MenuCategory } from 'src/app/Models/MenuCategory';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';
import { MenuService } from 'src/app/Services/MenuService/Menu.service';
@Component({
  selector: 'app-ThemDanhMucThucDon',
  templateUrl: './ThemDanhMucThucDon.component.html',
  styleUrls: ['./ThemDanhMucThucDon.component.css']
})
export class ThemDanhMucThucDonComponent implements OnInit {

  @Output() public hideshowOutput = new EventEmitter();
  public dataform!: FormGroup;
  constructor(private formbuilder:FormBuilder,private menuService:MenuService,private menuCategoryService: MenuCategoryService ) {
    this.CreateNewForm();
  }

  ngOnInit() {
  }
  public HideorShowPopup(){
      this.hideshowOutput.emit();
  }

  public CreateNewForm(){
      this.dataform = this.formbuilder.group({
        menuCategoryName: ['', [Validators.required]],
        menuCategoryId: [''],
        state: [true],
      });
  }
  public AddNewMenuCategory(){
    //  console.log(this.dataform.value);
     if(this.dataform.valid){
      let newmenuform = this.dataform.value;
       let newMenu:MenuCategory = new MenuCategory(
          newmenuform.menuCategoryId,
          newmenuform.menuCategoryName,
          newmenuform.state
       );
     this.menuCategoryService.AddNewMenuCategory(newMenu).subscribe((data) =>{
          let check = data.success;
          console.log(check);
          if(check){
            alert("Thêm danh mục thực đơn thành công!");
            this.dataform.reset();
          }
      });

     }
  }


}
