
using GroceryStoreSimulatorWebAPI.Models;

namespace GroceryStoreSimulatorWebAPI.DataAccess.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(IConfiguration configuration):base(configuration)
        {
           
        }
    }
}
