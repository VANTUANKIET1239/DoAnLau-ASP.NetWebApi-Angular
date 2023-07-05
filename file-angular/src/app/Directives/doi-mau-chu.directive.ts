import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appDoiMauChu]'
})
export class DoiMauChuDirective {

  @Input() public appDoiMauChu:string = '';
  constructor(private elementRef: ElementRef<HTMLElement>) { 
    
  }
  @HostListener('click') onClick() {
    const clickedElement = this.elementRef.nativeElement;
    const allLinks = document.querySelectorAll(`.${this.appDoiMauChu}`);
    
    
    allLinks.forEach(link => {
        link.classList.remove('active');
    });

    clickedElement.classList.add('active');
  }
}
