export const getAllOrders = `

query{
    order{
      orderID
      orderDetails{
        orderDetailId
        productID
        quantity
        totalAmountChargedToCustomer
      }
      store{
        storeNumber
        store
      }
      notes
      deliveryCharge
      dateTimeCreated
      dateTimeDelivered
      deliveryAddress
      
    }
  }


`