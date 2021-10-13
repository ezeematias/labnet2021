import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Shippers } from '../models/shippers';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {
  endPoint: string = 'Shippers';
  constructor(private http: HttpClient) { }

  public newShippers(shippersRequest: Shippers): Observable<any>{
    let url = environment.apiShippers + this.endPoint;
    return this.http.post(url,shippersRequest);
  }

  public getShippers():Observable<Array<Shippers>>{
    let url = environment.apiShippers + this.endPoint;
    return this.http.get<Array<Shippers>>(url);
  }

}
