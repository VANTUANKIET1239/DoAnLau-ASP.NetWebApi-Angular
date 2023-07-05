import { Directive, ElementRef, Input, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appCuonTrang]'
})
export class CuonTrangDirective {

  @Input() public appCuonTrang:string = '';
  constructor(private el: ElementRef, private renderer: Renderer2) {
    this.renderer.listen(this.el.nativeElement, 'click', () => {
      // const sectionId = this.el.nativeElement.getAttribute('appCuonTrang');
      const section = document.getElementById(this.appCuonTrang);
      if (section) {
        section.scrollIntoView({ behavior: 'smooth' });
      }
    });
  }


}
