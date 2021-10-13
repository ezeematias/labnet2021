import { Component, OnInit } from '@angular/core';
import { Shippers } from './models/shippers';
import { ShippersService } from './services/shippers.service';

@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.scss']
})
export class ShippersComponent implements OnInit {

  public ShippersList: Array<Shippers> = [];
  show = false;
  status: string = 'add';

  constructor(private ShippersService: ShippersService) { }

  ngOnInit(): void {
    this.getShippers();
  }

  ngDoCheck():void{
    this.statusShow();
    this.getShippers();
  }

  getShippers() {
    this.ShippersService.getShippers().subscribe(res =>{
      this.ShippersList = res;
      console.log(this.ShippersList);
    });
  }

  statusShow():void  {
    if(this.show)
    {
      this.status = 'minimize';
    }else{
      this.status = 'add'
    }
  }
}
