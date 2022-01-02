using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;
using GroceryStoreSimulatorWebAPI.Models;

namespace GroceryStoreSimulatorWebAPI.Services
{
    public class OrderDetailService : BaseService<OrderDetail>
    {

        public OrderDetailService(IBaseRepository<OrderDetail> baseDataAccess) : base(baseDataAccess)

        {
        }

      
    }
}
