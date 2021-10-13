import { Component, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup } from '@angular/forms';
import { Shippers } from '../models/shippers';
import { ShippersService } from '../services/shippers.service';
import { ShippersComponent } from '../shippers.component';

@Component({
  selector: 'app-form-shippers',
  templateUrl: './form-shippers.component.html',
  styleUrls: ['./form-shippers.component.scss']
})
export class FormShippersComponent implements OnInit {

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

  constructor(private readonly fb: FormBuilder, private shippersService: ShippersService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      id: [''],
      companyName: [''],
      phone: ['']
    })
  }

  onSubmit(): void {
    console.log(this.form.value);
  }

  onClickClean(): void {
    this.form.reset();
  }

  newShippers() {
    var shipper = new Shippers();
    shipper.CompanyName = this.companyNameCtrl.value;
    shipper.Phone = this.phoneCtrl.value;
    this.shippersService.newShippers(shipper).subscribe(res => { this.form.reset(); });
  }
}
