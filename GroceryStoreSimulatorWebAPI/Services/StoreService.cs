using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;
using GroceryStoreSimulatorWebAPI.Models;

namespace GroceryStoreSimulatorWebAPI.Services
{
    public class StoreService : BaseService<StoreModel>
    {
        public StoreService(IBaseRepository<StoreModel> repository) : base(repository)
        {
           

        }
      
    }
}
