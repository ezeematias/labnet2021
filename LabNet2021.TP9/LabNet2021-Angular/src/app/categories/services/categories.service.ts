import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { catchError } from 'rxjs/operators';
import { throwError as observableThrowError, Observable } from 'rxjs';
import { Categories } from '../models/categories';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  endPoint: string = 'Categories';
  categories!: Categories;
  categoriesList: Array<Categories> = [];
  url: any;

  constructor(private http: HttpClient) { }

  public newCategories(categoriesRequest: Categories): Observable<any> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.post(url, categoriesRequest).pipe(catchError(this.errorHandler));
  }

  public getCategories(): Observable<Array<Categories>> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.get<Array<Categories>>(url).pipe(catchError(this.errorHandler));;
  }

  public getCategoriesById(categoriesId: number): Observable<Categories> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.get<Categories>(url + '/' + categoriesId).pipe(catchError(this.errorHandler));
  }

  public deleteCategories(categoriesId: number): Observable<number> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.delete<number>(url + '/' + categoriesId).pipe(catchError(this.errorHandler));
  }

  public updateCategories(categoriesRequest: Categories): Observable<any> {
    let url = environment.apiShippers + this.endPoint;
    return this.http.put<Categories>(url + '/', categoriesRequest).pipe(catchError(this.errorHandler));
  }

  errorHandler(error: HttpErrorResponse) {
    return observableThrowError(error.message || 'Server Error');
  }
}
