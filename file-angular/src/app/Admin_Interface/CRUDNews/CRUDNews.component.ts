import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-CRUDNews',
  templateUrl: './CRUDNews.component.html',
  styleUrls: ['./CRUDNews.component.css']
})
export class CRUDNewsComponent implements OnInit {

  public categoryName: string = "";
  constructor(private route:ActivatedRoute) { }

  ngOnInit() {
    this.categoryName = <string> this.route.snapshot.paramMap.get("name");
  }

}
