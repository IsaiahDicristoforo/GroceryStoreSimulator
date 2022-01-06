import { Component, OnInit, ViewChild } from "@angular/core";
import { MatTable } from "@angular/material/table";
import { Order } from "./order";
import { OrdersListService } from "./orders-list.service";
import { getAllOrders } from "./orders.queries";


@Component({
    selector: 'order-list',
    templateUrl: './order-list.component.html',
    styleUrls: ['./order-list.styles.css']
})
export class OrderList implements OnInit{

    orders!: Order[] ;

    columnstoDisplay = ['orderID', 'storeNumber', 'dateTimeCreated', 'dateTimeDelivered', 'Notes', 'deliveryAddress']

    @ViewChild(MatTable) table!: MatTable<Order>;
    

    constructor(private orderService: OrdersListService){
      
    }
    ngOnInit(): void {
       this.orderService.getOrders({query: getAllOrders}).subscribe(result => {
          this.orders = result
      }) }

}