export interface Order{

    orderID: number
    LoyaltyId: number
    dateTimeCreated: Date
    StoreId: number
    OrderStatusId: number
    DeliveryCharge: number
    Notes: string,
    deliveryAddress: string
    dateTimeDelivered: Date
    AllOrNone: string
    OrderDetails: OrderDetails[]
    Store: Store;
}

export interface Store{
    storeId: number;
    store : string
    storeNumber: string;
}

export interface OrderDetails{

    OrderDetailId: number
    OrderId: number
    ProductId: number
    Quantity: number
    TotalAmountChargedToCustomer: number
    Comment: string
    CouponDetailId: number
    UnavailableWhenOrderWasFilled: boolean

}