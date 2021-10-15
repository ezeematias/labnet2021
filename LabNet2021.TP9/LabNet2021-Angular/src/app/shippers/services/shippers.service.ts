import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Shippers } from '../models/shippers';
import { catchError } from 'rxjs/operators';
import { throwError as observableThrowError, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {
  endPoint: string = 'Shippers';
  shippers!: Shippers;
  shippersList: Array<Shippers> = [];
  url: any;
  constructor(private http: HttpClient) { }

  public newShippers(shippersRequest: Shippers): Observable<any> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.post(url, shippersRequest).pipe(catchError(this.errorHandler));
  }

  public getShippers(): Observable<Array<Shippers>> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.get<Array<Shippers>>(url).pipe(catchError(this.errorHandler));;
  }

  public getShippersById(shipperid: number): Observable<Shippers> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.get<Shippers>(url + '/' + shipperid).pipe(catchError(this.errorHandler));
  }

  public deleteShipers(shipperid: number): Observable<number> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.delete<number>(url + '/' + shipperid).pipe(catchError(this.errorHandler));
  }

  public updateShippers(shippersRequest: Shippers): Observable<any> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.put<Shippers>(url + '/', shippersRequest).pipe(catchError(this.errorHandler));
  }

  errorHandler(error: HttpErrorResponse) {
    return observableThrowError(error.message || 'Server Error');
  }
}



