import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appDoiMauBtn]'
})
export class DoiMauBtnDirective {

  @Input() public appDoiMauBtn = '';
  constructor(private element:ElementRef<HTMLElement>) { }

  @HostListener('click') onClick(){
    const ele = this.element.nativeElement;
    const elediv = document.querySelectorAll(`.${this.appDoiMauBtn}`);
    elediv.forEach((el) => {
        el.classList.remove('btn-doimau-cate');
    });

    ele.classList.add('btn-doimau-cate');
  }
}
