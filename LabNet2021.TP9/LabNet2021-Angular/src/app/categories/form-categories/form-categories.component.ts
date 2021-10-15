import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';
import { CategoriesComponent } from '../categories.component';
import { Categories } from '../models/categories';
import { CategoriesService } from '../services/categories.service';

@Component({
  selector: 'app-form-categories',
  templateUrl: './form-categories.component.html',
  styleUrls: ['./form-categories.component.scss']
})
export class FormCategoriesComponent implements OnInit {

  @Input() categoriesParent!: Categories;
  @Input() edit!: boolean;
  @Input() search!: boolean;
  @Output() idSearch = new EventEmitter<number>();
  @Output() cancelSearch = new EventEmitter<boolean>();

  form!: FormGroup;

  get categoryNameCtrl(): AbstractControl {
    return this.form.get('categoryName') as FormGroup;
  }

  get descriptionCtrl(): AbstractControl {
    return this.form.get('description') as FormGroup;
  }

  get idCtrl(): AbstractControl {
    return this.form.get('id') as FormGroup;
  }

  constructor(private readonly fb: FormBuilder, private categoriesService: CategoriesService, private categoriesComponent: CategoriesComponent) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      id: [''],
      categoryName: ['', [Validators.minLength(3), Validators.maxLength(15)]],
      description: ['', Validators.maxLength(100)]
    });
    if (this.edit) {
      this.updateSet(this.categoriesParent);
    }
  }

  getValue(value:string): AbstractControl {
    return this.form.get(value) as FormGroup;
  }

  ngOnChanges(): void {
    if (this.edit) {
      this.updateSet(this.categoriesParent);
    }
  }

  onSubmit(): void {
    //console.log(this.form.value);
  }

  onClickClean(): void {
    this.form.reset();
  }

  newCategories() {
    var category = new Categories();
    category.CategoryName = this.categoryNameCtrl.value;
    category.Description = this.descriptionCtrl.value;
    this.categoriesService.newCategories(category).subscribe(res => {
      this.form.reset();
      this.ngOnInit();
      this.categoriesComponent.ngOnInit();
      this.modalMessage('Added correctly');
    });
  }

  updateSet(categories: Categories) {
    this.form = this.fb.group({
      id: [categories.Id],
      categoryName: [categories.CategoryName, [Validators.minLength(3), Validators.maxLength(15)]],
      description: [categories.Description, Validators.maxLength(100)]
    });
  }

  updateCategories() {
    var bufferCategories = this.categoriesParent;
    bufferCategories.CategoryName = this.categoryNameCtrl.value;
    bufferCategories.Description = this.descriptionCtrl.value;
    this.categoriesService.updateCategories(bufferCategories).subscribe(res => {
      this.categoriesComponent.ngOnInit();
      this.modalMessage('Edited correctly');
    });
  }

  sendMessageParent(){
    this.idSearch.emit(this.idCtrl.value);
  }

  sendCancelSearch(){
    this.cancelSearch.emit(true);
  }

  modalMessage(msg:string){
    Swal.fire({
      position: 'center',
      icon: 'success',
      title: msg,
      showConfirmButton: false,
      timer: 1500
    })
  }

}
