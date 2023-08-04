import { Component, Input, OnChanges, OnInit, SimpleChanges, Output, EventEmitter, ElementRef, AfterViewInit, AfterContentChecked } from '@angular/core';

@Component({
  selector: 'app-Pagination',
  templateUrl: './Pagination.component.html',
  styleUrls: ['./Pagination.component.css']
})
export class PaginationComponent implements OnInit,OnChanges, AfterContentChecked{

  @Input() public pageIndex:number = 0;
  @Input() public totalPage:number  = 1;
  @Output() public eventPage = new EventEmitter();
  public totalPageView: number[] = [];
  public prelock: boolean = true;
  public nextlock: boolean = false;
  constructor() {

   }
  ngAfterContentChecked(): void {

  }
  ngAfterViewInit(): void {

  }
  ngOnChanges(changes: SimpleChanges): void {
      console.log(this.pageIndex);
      this.PageSize();
  }
  public PageSize():void{
    let totalpage:number[] = [];
    for(let i = 1; i <= this.totalPage;i++){
      totalpage.push(i);
    }
    this.totalPageView = totalpage;
    console.log(this.totalPageView);

  }
  public ChangePage(event:number):void{
    this.pageIndex = event;
    this.CheckPage();
    this.eventPage.emit(event);
  }
  private CheckPage():void{

      if(this.pageIndex === 1){
          this.prelock = true;
          this.nextlock = false;
      }
      if(this.pageIndex === this.totalPage){
          this.nextlock = true;
          this.prelock = false;
      }

  }
  public ChangePagePreNext(condition: string){
      if(condition === "PRE"){
        this.pageIndex -= 1;
        this.CheckPage();
        this.eventPage.emit(this.pageIndex);

      }
      else{
          this.pageIndex += 1;
          this.eventPage.emit(this.pageIndex);
          this.CheckPage()
      }
  }
  ngOnInit() {

  }

}
