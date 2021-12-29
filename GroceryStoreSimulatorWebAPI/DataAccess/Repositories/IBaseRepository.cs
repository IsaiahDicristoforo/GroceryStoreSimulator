namespace GroceryStoreSimulatorWebAPI.DataAccess.Repositories
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        IEnumerable<T> Get();
        long Post(T item);
        long Post(IEnumerable<T> items);
        bool Put(T item);
        bool Delete(T item);

    }
}   
