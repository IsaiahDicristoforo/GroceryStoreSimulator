using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;
using GroceryStoreSimulatorWebAPI.Models;

namespace GroceryStoreSimulatorWebAPI.Services
{
    public class OrderService : BaseService<Order>
    {
        private readonly OrderRepository baseDataAccess;

        public OrderService(OrderRepository baseDataAccess) : base(baseDataAccess)
        {
            this.baseDataAccess = baseDataAccess;
        }

      
    }
}
