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
constructor(private httpclient: HttpClient) { }

  public GetMenus(): Observable<Menu[]>{
    const url = `${this.REST_API_SERVER}`;
    return this.httpclient.get<Menu[]>(url,this.httpOptions);
  }
  public GetMenusByCate(cateid:string): Observable<Menu[]>{
    const url = `${this.REST_API_SERVER}/MenuCategory/${cateid}`;
    return this.httpclient.get<Menu[]>(url,this.httpOptions);
  }
}
