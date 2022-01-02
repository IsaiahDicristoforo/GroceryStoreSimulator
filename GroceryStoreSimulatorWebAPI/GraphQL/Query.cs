using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;
using GroceryStoreSimulatorWebAPI.Models;
using GroceryStoreSimulatorWebAPI.Services;

namespace GroceryStoreSimulatorWebAPI.GraphQL
{
    public class Query
    {
        private readonly OrderService service;
        private readonly OrderDetailService orderDetailService;
        private readonly StoreService storeService;

        public Query(OrderService service, OrderDetailService orderDetailService,  StoreService storeService)
        {
            this.service = service;
            this.orderDetailService = orderDetailService;
            this.storeService = storeService;
        }

        public List<Order> GetOrder()
        {
            return service.Get().ToList();

        }

        public List<OrderDetail> GetOrderDetails()
        {
            return orderDetailService.Get().ToList();
        }

        public List<StoreModel> GetStores() => storeService.Get().ToList();
    }

    public class OrderType : ObjectType<Order>
    {
      
        protected override void Configure(IObjectTypeDescriptor<Order> descriptor)
        {

            descriptor.Description("Represents some order");
           
            descriptor
                .Field(f => f.OrderDetails).Argument("OrderId", a => a.Type<InputObjectType<Order>>()).ResolveWith<Resolvers>(r => r.GetOrderDetailsFromOrderId(default!, default!));

            descriptor.Field(f => f.Store).Argument("OrderId", a => a.Type<InputObjectType<Order>>()).ResolveWith<Resolvers>(r => r.GetStoreFromOrderId(default!, default!));
        }

    }

    public class Resolvers
    {
        public List<OrderDetail> GetOrderDetailsFromOrderId([Parent] Order order, [Service] BaseRepository<OrderDetail> repo)
        {
    
            return repo.ExecuteQuery<OrderDetail>("SELECT * FROM tOrderDetail WHERE OrderId = " + order.OrderID);
        }

        public StoreModel GetStoreFromOrderId([Parent] Order order, [Service] BaseRepository<OrderDetail> repo)
        {
            return repo.ExecuteQuerySingle<StoreModel>("SELECT * FROM tStore s WHERE s.StoreId = " + order.StoreId);

        }
    }

    

   
}

