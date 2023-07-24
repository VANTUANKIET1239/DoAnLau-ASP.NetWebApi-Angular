import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-CRUDMenuCategory',
  templateUrl: './CRUDMenuCategory.component.html',
  styleUrls: ['./CRUDMenuCategory.component.css']
})
export class CRUDMenuCategoryComponent implements OnInit {

  public categoryName: string = "";
  constructor(private route:ActivatedRoute) { }

  ngOnInit() {
    this.categoryName = <string> this.route.snapshot.paramMap.get("name");
  }

}
