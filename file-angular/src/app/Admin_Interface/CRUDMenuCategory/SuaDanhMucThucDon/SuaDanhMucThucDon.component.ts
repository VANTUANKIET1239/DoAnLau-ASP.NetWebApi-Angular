import { Component, ElementRef, OnInit, ViewChild, Output, EventEmitter, Input, AfterViewInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Menu } from 'src/app/Models/Menu';
import { MenuCategory } from 'src/app/Models/MenuCategory';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';
import { MenuService } from 'src/app/Services/MenuService/Menu.service';

@Component({
  selector: 'app-SuaDanhMucThucDon',
  templateUrl: './SuaDanhMucThucDon.component.html',
  styleUrls: ['./SuaDanhMucThucDon.component.css']
})
export class SuaDanhMucThucDonComponent implements OnInit {

  public selectedImage: string  = '';

  @ViewChild("hinhanhmenu",{ static: false }) public elelinkimg!:ElementRef<HTMLInputElement>;
  @Output() public hideshowOutputEdit = new EventEmitter();
  public dataform!: FormGroup;

  @Input() public menuCategoryEdit:MenuCategory = new MenuCategory('','',true);
  constructor(private formbuilder:FormBuilder,private menuService:MenuService,private menuCategoryService: MenuCategoryService ) {

  }
  ngAfterViewInit(): void {
  }

  ngOnInit() {
    this.CreateNewForm();
  }
  onLinkSelected() {
      this.selectedImage = this.elelinkimg.nativeElement.value;
  }

  public HideorShowPopup(){
      this.hideshowOutputEdit.emit();
  }

  public CreateNewForm(){
    console.log(this.menuCategoryEdit);
      this.dataform = this.formbuilder.group({
        menuCategoryName: [this.menuCategoryEdit.categoryName],
        menuCategoryId: [this.menuCategoryEdit.menuCategory_Id],
        state: [this.menuCategoryEdit.state],
      });


  }
  public EditNewMenu(){
    //  console.log(this.dataform.value);
     if(this.dataform.valid){
      let newmenuform = this.dataform.value;
       let newMenu:MenuCategory = new MenuCategory(
            newmenuform.menuCategoryId,
            newmenuform.menuCategoryName,
            newmenuform.state,
       );
      this.menuCategoryService.EditMenuCategory(newMenu).subscribe((data) =>{
          let check = data.success;
          if(check){
            this.hideshowOutputEdit.emit();
            alert("Chỉnh sửa danh mục thực đơn thành công!");
            this.LoadComponent();
          }
      });

     }
  }
  public LoadComponent(){
    window.location.reload();
  }
}
