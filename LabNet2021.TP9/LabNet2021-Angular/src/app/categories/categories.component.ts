import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';
import { Categories } from './models/categories';
import { CategoriesService } from './services/categories.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  public categoriesList: Array<Categories> = [];
  sendCategories!: Categories;
  categoriesBuffer!: Categories;
  categoriesEdit!: boolean;
  searchCategories!: boolean;
  show = false;
  status: string = 'add';
  displayedColumns: string[] = ['ID', 'Category Name', 'Description', 'Edit', 'Delete'];

  constructor(private categoriesService: CategoriesService) { }

  ngOnInit(): void {
    this.getCategories();
  }

  ngDoCheck(): void {
    this.statusShow();
  }

  getCategories() {
    this.categoriesService.getCategories().subscribe(res => {
      this.categoriesList = res;
      console.log(this.categoriesList);
    },    error => this.errorMessage("No categories found")
    );
  }

  cancelSearch(cancel:boolean)
  {
    if(cancel)
    {
      this.getCategories();
    }
  }

  getCategoriesById(id: number)
  {
    this.categoriesService.getCategoriesById(id).subscribe(res =>{
      this.categoriesBuffer = res;
      this.categoriesList = [this.categoriesBuffer];
    },
     error => this.errorMessage("ID does not exist")
    );
  }

  deleteShippers(id: number) {
    this.categoriesService.deleteCategories(id).subscribe(res => {
      this.ngOnInit();
    }, error => this.errorMessage("Could not delete the category"));
  }

  updateSet(categories: Categories) {
    this.sendCategories = categories;
    this.searchCategories = false;
    this.categoriesEdit = true;
  }

  searchSet():void{
    this.categoriesEdit = false;
    this.searchCategories = true;
  }

  statusShow(): void {
    if (this.show) {
      this.status = 'minimize';
    } else {
      this.status = 'add'
    }
  }

  showModal(categoriesId: number){
    Swal.fire({
      title: 'Are you sure?',
      text: "You won't be able to revert this!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
      if (result.isConfirmed) {
        Swal.fire(
          'Deleted!',
          'Your file has been deleted.',
          'success'
        )
        this.deleteShippers(categoriesId);
      }
    })
  }

  errorMessage(msg : string)  {
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: msg,
    })
  }

}
