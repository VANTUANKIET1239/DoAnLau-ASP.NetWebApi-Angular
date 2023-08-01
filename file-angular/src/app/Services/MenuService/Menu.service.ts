import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Menu } from 'src/app/Models/Menu';

@Injectable({
  providedIn: 'root'
})
export class MenuService {
  private REST_API_SERVER = 'https://localhost:7204/api/Menu';
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':'application/json',
    }),
  }
  // private httpOptions2 = {
  //   headers: new HttpHeaders({
  //     'Content-Type': 'text/plain',
  //   }),
  // }
  private headers = new HttpHeaders({
    'Content-Type': 'text/plain',
  });

constructor(private httpclient: HttpClient) { }

  public GetMenus(): Observable<Menu[]>{
    const url = `${this.REST_API_SERVER}`;
    return this.httpclient.get<Menu[]>(url,this.httpOptions);
  };
  public AddNewMenu(cateId: string, menu:Menu): Observable<any>{
    const url = `${this.REST_API_SERVER}/AddMenu?MenuCategoryId=${cateId}`;
    return this.httpclient.post<Menu>(url,menu,this.httpOptions);
  };
  public EditMenu(cateId: string, menu:Menu): Observable<any>{
    const url = `${this.REST_API_SERVER}/EditMenu?MenuCategoryId=${cateId}`;
    return this.httpclient.post<Menu>(url,menu,this.httpOptions);
  }
  public GetMenusByCate(cateid:string): Observable<Menu[]>{
    const url = `${this.REST_API_SERVER}/MenuCategory/${cateid}`;
    return this.httpclient.get<Menu[]>(url,this.httpOptions);
  };
  public RemoveMenu(menu:Menu): Observable<any>{
    const url = `${this.REST_API_SERVER}/RemoveMenu`;
    const headers = new HttpHeaders({
      'Content-Type': 'text/json',
    });
    return this.httpclient.post<Menu>(url,menu,{headers: headers});
  };
}
