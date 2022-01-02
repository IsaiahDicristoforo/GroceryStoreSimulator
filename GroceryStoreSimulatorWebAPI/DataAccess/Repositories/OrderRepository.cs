
using GroceryStoreSimulatorWebAPI.Models;
using System.Data.SqlClient;
using Dapper;

namespace GroceryStoreSimulatorWebAPI.DataAccess.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(IConfiguration configuration):base(configuration)
        {
           
        }

        public List<Order> OrderSummaryDetails()
        {
            var orderDictionary = new Dictionary<int, Order>();

            using (SqlConnection connection = base.GetSqlConnection())
            {
                List<Order> summary = connection.Query<Order, OrderDetail, Order>("SELECT * FROM tOrder LEFT OUTER JOIN tOrderDetail ON tOrder.OrderID = tOrderDetail.OrderID",
                     (order, orderDetail) =>
                     {
                         Order orderEntry;

                         if (!orderDictionary.TryGetValue(order.OrderID, out orderEntry))
                         {
                             orderEntry = order;
                             orderEntry.OrderDetails = new List<OrderDetail>();
                             orderDictionary.Add(orderEntry.OrderID, orderEntry);
                         }

                         orderEntry.OrderDetails.Add(orderDetail);
                         return orderEntry;

                     }, splitOn: "OrderDetailId").ToList();

                return summary;
                
            }

        }
    }
}
