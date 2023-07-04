import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appDoiMauChu]'
})
export class DoiMauChuDirective {

  constructor(private elementRef: ElementRef<HTMLElement>) { 
    
  }
  @HostListener('click') onClick() {
    const clickedElement = this.elementRef.nativeElement;
    const allLinks = document.querySelectorAll('.a-cate');
    
    // Loại bỏ lớp 'active' cho tất cả các thẻ <a>
    allLinks.forEach(link => {
        link.classList.remove('active')
    });

    // Thêm lớp 'active' cho thẻ <a> được nhấp vào
    clickedElement.classList.add('active');
  }
}
