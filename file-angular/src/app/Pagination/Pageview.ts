export class PageViewModel{
      pageIndex:number;
      pageSize:number;
      totalCount: number;
      totalPage:number;

      constructor(
        pageIndex:number,
        pageSize:number,
        totalCount: number){
          this.pageIndex = pageIndex;
          this.pageSize = pageSize;
          this.totalCount = totalCount;
          this.totalPage = Math.ceil(totalCount/pageSize);
        }

}
