import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, Renderer2 } from '@angular/core';
import { Observable } from 'rxjs';
import { MenuCategory } from 'src/app/Models/MenuCategory';

@Injectable({
  providedIn: 'root'
})
export class MenuCategoryService {
private REST_API_SERVER = 'https://localhost:7204/api/MenuCategory';
private httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':'application/json',
  }),
}
constructor(private httpclient : HttpClient) { }

public GetMenuCategories():Observable<MenuCategory[]>{
   const url = `${this.REST_API_SERVER}`;
   return this.httpclient.get<MenuCategory[]>(url,this.httpOptions);
}
public AddNewMenuCategory(menuCategory:MenuCategory): Observable<any>{
  const url = `${this.REST_API_SERVER}/AddMenuCategory`;
  return this.httpclient.post<MenuCategory>(url,menuCategory,this.httpOptions);
};
public EditMenuCategory(menuCategory:MenuCategory): Observable<any>{
  const url = `${this.REST_API_SERVER}/EditMenuCategory`;
  return this.httpclient.post<MenuCategory>(url,menuCategory,this.httpOptions);
}
public RemoveMenuCategory(menuCategory:MenuCategory): Observable<any>{
  const url = `${this.REST_API_SERVER}/RemoveMenuCategory`;
  return this.httpclient.post<MenuCategory>(url,menuCategory,this.httpOptions);
};



}
