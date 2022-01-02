using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace GroceryStoreSimulatorWebAPI.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        private readonly IConfiguration configuration;

        public BaseRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<U> ExecuteQuery<U>(string queryToExecute)
        {
            using(SqlConnection connection = GetSqlConnection())
            {
                return connection.Query<U>(queryToExecute).ToList();
            }
        }
        public U ExecuteQuerySingle<U>(string queryToExecute)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                return (U)connection.QuerySingle<U>(queryToExecute);
            }
        }

        public T Get(int id)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> Get()
        {
            using(SqlConnection connection = GetSqlConnection())
            {
                return connection.GetAll<T>();
            }
        }

        public long Post(T item)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                return connection.Insert<T>(item);
            }
        }

        public long Post(IEnumerable<T> items)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                return connection.Insert<T>((T)items);
            }
        }

        public bool Put(T item)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
               return connection.Update<T>(item);
            }
        }

        public bool Delete(T item)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                return connection.Delete<T>(item);
            }
        }

        protected SqlConnection GetSqlConnection()
        {
            SqlConnection connectionToReturn = new SqlConnection(configuration.GetConnectionString("GroceryStoreSimConnectionString"));
            connectionToReturn.Open();
            return connectionToReturn;
            
        }
    }   
}
