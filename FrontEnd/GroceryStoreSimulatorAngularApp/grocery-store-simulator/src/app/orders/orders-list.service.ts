import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map, Observable, tap } from "rxjs";
import { Order } from "./order";

@Injectable({
    providedIn: "root"
})
export class OrdersListService{


    public getOrders(options: {
        query: string;
        variables?: { [key: string]: any };
      }): Observable<Order[]> {
        return this.httpClient
          .post<{data: any }>(`https://localhost:7258/graphql`, {
            query: options.query,
            variables: options.variables,
          }).pipe(map((d) => d.data), map((result) => Object.values(result)[0] as Order[]))
      }

    

    constructor(private httpClient: HttpClient){

    }

}