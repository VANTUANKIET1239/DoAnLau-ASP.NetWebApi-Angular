import { Component, ElementRef, OnInit, ViewChild, Output, EventEmitter, Input, AfterViewInit, AfterViewChecked } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Menu } from 'src/app/Models/Menu';
import { MenuCategory } from 'src/app/Models/MenuCategory';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';
import { MenuService } from 'src/app/Services/MenuService/Menu.service';


@Component({
  selector: 'app-SuaThucDonPopUp',
  templateUrl: './SuaThucDonPopUp.component.html',
  styleUrls: ['./SuaThucDonPopUp.component.css']
})
export class SuaThucDonPopUpComponent implements OnInit, AfterViewChecked {
  public selectedImage: string  = '../../../assets/Image/default_image.jpg';
  @ViewChild("hinhanhmenu",{ static: false }) public elelinkimg!:ElementRef<HTMLInputElement>;
  @Output() public hideshowOutputEdit = new EventEmitter();
  public dataform: FormGroup = this.formbuilder.group({
    menuId:[''],
    menuName: ['', [Validators.required]],
    menuImage: ['', [Validators.required]],
    menuPrice: ['', [Validators.required]],
    hotDeal: [true],
    bestSaller: [true],
    menuCategory: [''],
    state:[true],

  });;
  public catelist: MenuCategory[] = [];

  @Input() public menuEdit:Menu = new Menu('','','',0,true,true,true);
  constructor(private formbuilder:FormBuilder,private menuService:MenuService,private menuCategoryService: MenuCategoryService ) {
    this.menuCategoryService.GetMenuCategories().subscribe((data) =>{
      this.catelist = data;
      this.CreateNewForm();
    });

  }
  ngAfterViewChecked(): void {

  }

  ngOnInit() {
    this.selectedImage = this.menuEdit.menuImage;
  }
  onLinkSelected() {
      this.selectedImage = this.elelinkimg.nativeElement.value;
  }

  public HideorShowPopup(){
      this.hideshowOutputEdit.emit();
  }

  public CreateNewForm(){
      let currentCategory: MenuCategory[] = this.catelist.filter(x => x.menuCategory_Id == this.menuEdit.menu_Id);
      console.log(this.menuEdit);
      this.dataform = this.formbuilder.group({
        menuId:[this.menuEdit.menu_Id],
        menuName: [this.menuEdit.menuName, [Validators.required]],
        menuImage: [this.menuEdit.menuImage, [Validators.required]],
        menuPrice: [this.menuEdit.price, [Validators.required]],
        hotDeal: [this.menuEdit.hotDeal],
        bestSaller: [this.menuEdit.bestSaller],
        menuCategory: [''],
        state:[this.menuEdit.state],
      });

  }
  public EditNewMenu(){
    //  console.log(this.dataform.value);
     if(this.dataform.valid){
      let newmenuform = this.dataform.value;
       let newMenu:Menu = new Menu(
            newmenuform.menuId,
            newmenuform.menuName,
            newmenuform.menuImage,
            newmenuform.menuPrice,
            newmenuform.hotDeal,
            newmenuform.bestSaller,
            newmenuform.state
       );
      this.menuService.EditMenu(newmenuform.menuCategory,newMenu).subscribe((data) =>{
          let check = data.success;
          if(check){
            this.hideshowOutputEdit.emit();
            alert("Chỉnh sửa thực đơn thành công!");
          }
      });

     }
  }
}
