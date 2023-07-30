import { Component, Input, OnChanges, OnInit, SimpleChanges, Output, EventEmitter, ElementRef } from '@angular/core';

@Component({
  selector: 'app-Pagination',
  templateUrl: './Pagination.component.html',
  styleUrls: ['./Pagination.component.css']
})
export class PaginationComponent implements OnInit,OnChanges {

  @Input() public pageIndex:number = 0;
  @Input() public pageSize:number = 0;
  @Input() public totalCount:number = 0;
  @Output() public eventPage = new EventEmitter();
  public totalPage:number = 0;
  public totalPageView: number[] = [];
  public prelock: boolean = true;
  public nextlock: boolean = false;
  constructor() {
   }
  ngOnChanges(changes: SimpleChanges): void {
        this.totalPage = Math.ceil(this.totalCount/this.pageSize);
       this.PageSize();
  }
  public PageSize():void{
    let totalpage:number[] = [];
    for(let i = 1; i <= this.totalPage;i++){
      totalpage.push(i);
    }
    this.totalPageView = totalpage;
  }
  public ChangePage(event:number):void{
    this.pageIndex = event;
    this.CheckPage();
    this.eventPage.emit(event);
  }
  private CheckPage():void{
      if(this.pageIndex == 1){
          this.prelock = true;
      }
      else if(this.pageIndex == this.totalPage){
          this.nextlock = true;
      }
      else{
        this.prelock = false;
        this.nextlock = false;
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
        this.CheckPage();
        this.eventPage.emit(this.pageIndex);
      }
  }
  ngOnInit() {


  }

}
