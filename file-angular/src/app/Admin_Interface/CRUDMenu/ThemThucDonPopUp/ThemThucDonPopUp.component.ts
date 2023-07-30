import { Component, ElementRef, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Menu } from 'src/app/Models/Menu';
import { MenuCategory } from 'src/app/Models/MenuCategory';
import { MenuCategoryService } from 'src/app/Services/MenuCategoryService/MenuCategory.service';
import { MenuService } from 'src/app/Services/MenuService/Menu.service';

@Component({
  selector: 'app-ThemThucDonPopUp',
  templateUrl: './ThemThucDonPopUp.component.html',
  styleUrls: ['./ThemThucDonPopUp.component.css']
})
export class ThemThucDonPopUpComponent implements OnInit {
  public selectedImage: string  = '../../../assets/Image/default_image.jpg';
  @ViewChild("hinhanhmenu",{ static: false }) public elelinkimg!:ElementRef<HTMLInputElement>;
  @Output() public hideshowOutput = new EventEmitter();
  public dataform!: FormGroup;
  public catelist: MenuCategory[] = [];
  constructor(private formbuilder:FormBuilder,private menuService:MenuService,private menuCategoryService: MenuCategoryService ) {
   menuCategoryService.GetMenuCategories().subscribe((data) =>{
        this.catelist = data;
   });
    this.CreateNewForm();

  }

  ngOnInit() {
  }
  onLinkSelected() {
      this.selectedImage = this.elelinkimg.nativeElement.value;
  }

  public HideorShowPopup(){
      this.hideshowOutput.emit();
  }

  public CreateNewForm(){
      this.dataform = this.formbuilder.group({
        menuName: ['', [Validators.required]],
        menuImage: ['', [Validators.required]],
        menuPrice: [0, [Validators.required]],
        hotDeal: [false],
        bestSaller: [false],
        menuCategory: [''],
      });
  }
  public AddNewMenu(){
    //  console.log(this.dataform.value);
     if(this.dataform.valid){
      let newmenuform = this.dataform.value;
       let newMenu:Menu = new Menu(
          '',
            newmenuform.menuName,
            newmenuform.menuImage,
            newmenuform.menuPrice,
            newmenuform.hotDeal,
            newmenuform.bestSaller,
            true
       );
      this.menuService.AddNewMenu(newmenuform.menuCategory,newMenu).subscribe((data) =>{
          let check = data.success;
          if(check){
            alert("Thêm thực đơn thành công!");
            this.dataform.reset();
          }
      });

     }
  }
}
