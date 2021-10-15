import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';
import { Shippers } from '../models/shippers';
import { ShippersService } from '../services/shippers.service';
import { ShippersComponent } from '../shippers.component';

@Component({
  selector: 'app-form-shippers',
  templateUrl: './form-shippers.component.html',
  styleUrls: ['./form-shippers.component.scss']
})
export class FormShippersComponent implements OnInit {

  @Input() shippersParent!: Shippers;
  @Input() edit!: boolean;
  @Input() search!: boolean;
  @Output() idSearch = new EventEmitter<number>();
  @Output() cancelSearch = new EventEmitter<boolean>();

  form!: FormGroup;

  get companyNameCtrl(): AbstractControl {
    return this.form.get('companyName') as FormGroup;
  }

  get phoneCtrl(): AbstractControl {
    return this.form.get('phone') as FormGroup;
  }

  get idCtrl(): AbstractControl {
    return this.form.get('id') as FormGroup;
  }

  constructor(private readonly fb: FormBuilder, private shippersService: ShippersService, private shippersComponent: ShippersComponent) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      id: [''],
      companyName: ['', [Validators.minLength(3), Validators.maxLength(40)]],
      phone: ['', Validators.pattern("^[(]*[0-9]*[0-9]*[)]*[' ']*[0-9]*[0-9]*[-]*[0-9]*$")]
    });
    if (this.edit) {
      this.updateSet(this.shippersParent);
    }
  }

  getValue(value:string): AbstractControl {
    return this.form.get(value) as FormGroup;
  }

  ngOnChanges(): void {
    if (this.edit) {
      this.updateSet(this.shippersParent);
    }
  }

  onSubmit(): void {
    //console.log(this.form.value);
  }

  onClickClean(): void {
    this.form.reset();
  }

  newShippers() {
    var shipper = new Shippers();
    shipper.CompanyName = this.companyNameCtrl.value;
    shipper.Phone = this.phoneCtrl.value;
    this.shippersService.newShippers(shipper).subscribe(res => {
      this.form.reset();
      this.ngOnInit();
      this.shippersComponent.ngOnInit();
      this.modalMessage('Added correctly');
    });
  }

  updateSet(shippers: Shippers) {
    this.form = this.fb.group({
      id: [shippers.Id],
      companyName: [shippers.CompanyName, [Validators.minLength(3), Validators.maxLength(40)]],
      phone: [shippers.Phone, Validators.pattern("^[(]*[0-9]*[0-9]*[)]*[' ']*[0-9]*[0-9]*[-]*[0-9]*$")]
    });
  }

  updateShippers() {
    var bufferShippers = this.shippersParent;
    bufferShippers.CompanyName = this.companyNameCtrl.value;
    bufferShippers.Phone = this.phoneCtrl.value;
    this.shippersService.updateShippers(bufferShippers).subscribe(res => {
      this.shippersComponent.ngOnInit();
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
