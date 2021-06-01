import { Component, OnInit } from '@angular/core';
import { ItemService } from '../shared/item.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  
  constructor(private itemservice:ItemService) { }
itemlist:any=[]
  ngOnInit() {
    this.itemservice.getItemList().then((result)=>
   
    this.itemlist=result);
    console.warn(this.itemlist)
  }

}
