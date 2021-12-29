using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;
using GroceryStoreSimulatorWebAPI.Models;

namespace GroceryStoreSimulatorWebAPI.Services
{
    public class OrderService : BaseService<Order>
    {
        public OrderService(IBaseRepository<Order> baseDataAccess) : base(baseDataAccess)
        {
        }
    }
}
