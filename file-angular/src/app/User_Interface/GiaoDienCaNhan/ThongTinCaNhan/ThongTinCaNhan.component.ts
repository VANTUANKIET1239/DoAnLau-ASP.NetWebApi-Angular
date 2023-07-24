import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ThongTinCaNhan',
  templateUrl: './ThongTinCaNhan.component.html',
  styleUrls: ['./ThongTinCaNhan.component.css']
})
export class ThongTinCaNhanComponent implements OnInit {

  public selectedImage: string  = '../../../assets/Image/default_image.jpg';
  constructor() { }

  ngOnInit() {
  }
 

  onFileSelected(event: any) {
    const file: File = event.target.files[0];
    const reader = new FileReader();

    reader.onload = (e: any) => {
      this.selectedImage = e.target.result;
    };

    reader.readAsDataURL(file);
  }
}
