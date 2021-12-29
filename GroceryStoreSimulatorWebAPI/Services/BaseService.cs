using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;

namespace GroceryStoreSimulatorWebAPI.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> baseDataAccess;

        public BaseService(IBaseRepository<T> baseDataAccess)
        {
            this.baseDataAccess = baseDataAccess;
        }

        public bool Delete(T item)
        {
           return baseDataAccess.Delete(item);
        }

        public T Get(int id)
        {
            return baseDataAccess.Get(id);
        }

        public IEnumerable<T> Get()
        {
            return baseDataAccess.Get();
        }

        public long Post(T item)
        {
            return baseDataAccess.Post(item);
        }

        public long Post(IEnumerable<T> items)
        {
            return baseDataAccess.Post(items);
        }

        public bool Put(T item)
        {
            return baseDataAccess.Put(item);
        }
    }
}
