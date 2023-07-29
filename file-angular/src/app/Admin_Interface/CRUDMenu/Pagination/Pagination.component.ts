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
  constructor() {
   }
  ngOnChanges(changes: SimpleChanges): void {
        console.log(this.pageIndex);
        console.log(this.pageSize);
        console.log(this.totalCount);
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
    this.eventPage.emit(event);
    console.log("pagination event " + event);
  }
  ngOnInit() {


  }

}
