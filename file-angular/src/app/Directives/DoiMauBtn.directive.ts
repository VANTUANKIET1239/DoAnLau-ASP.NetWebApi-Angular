import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appDoiMauBtn]'
})
export class DoiMauBtnDirective {

  constructor(private element:ElementRef<HTMLElement>) { }

  @HostListener('click') onClick(){
    const ele = this.element.nativeElement;
    const elediv = document.querySelectorAll('.cate-div');
    elediv.forEach((el) => {
        el.classList.remove('btn-doimau-cate');
    });

    ele.classList.add('btn-doimau-cate');
  }
}
