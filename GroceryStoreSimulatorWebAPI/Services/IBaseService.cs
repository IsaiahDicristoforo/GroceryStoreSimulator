namespace GroceryStoreSimulatorWebAPI.Services
{
    public interface IBaseService<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> Get();
        long Post(T item);
        long Post(IEnumerable<T> items);
        bool Put(T item);
        bool Delete(T item);
    }
}
