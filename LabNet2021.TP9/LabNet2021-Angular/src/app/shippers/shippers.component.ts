import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';
import { Shippers } from './models/shippers';
import { ShippersService } from './services/shippers.service';

@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.scss']
})
export class ShippersComponent implements OnInit {

  public ShippersList: Array<Shippers> = [];
  sendShippers!: Shippers;
  shipperBuffer!: Shippers;
  shipperEdit!: boolean;
  searchShippers!: boolean;
  show = false;
  status: string = 'add';
  displayedColumns: string[] = ['ID', 'Company Name', 'Phone', 'Edit', 'Delete'];

  constructor(private ShippersService: ShippersService) { }

  ngOnInit(): void {
    this.getShippers();
  }

  ngDoCheck(): void {
    this.statusShow();
  }

  getShippers() {
    this.ShippersService.getShippers().subscribe(res => {
      this.ShippersList = res;
      console.log(this.ShippersList);
    },    error => this.errorMessage("No shippers found")
    );
  }

  cancelSearch(cancel:boolean)
  {
    if(cancel)
    {
      this.getShippers();
    }
  }

  getShippersById(id: number)
  {
    this.ShippersService.getShippersById(id).subscribe(res =>{
      this.shipperBuffer = res;
      this.ShippersList = [this.shipperBuffer];
    },
     error => this.errorMessage("ID does not exist")
    );
  }

  deleteShippers(id: number) {
    this.ShippersService.deleteShipers(id).subscribe(res => {
      this.ngOnInit();
    }, error => this.errorMessage("Could not delete the shipper"));
  }

  updateSet(shippers: Shippers) {
    this.sendShippers = shippers;
    this.searchShippers = false;
    this.shipperEdit = true;
  }

  searchSet():void{
    this.shipperEdit = false;
    this.searchShippers = true;
  }

  statusShow(): void {
    if (this.show) {
      this.status = 'minimize';
    } else {
      this.status = 'add'
    }
  }

  showModal(shipperId: number){
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
        this.deleteShippers(shipperId);
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
