using Dapper.Contrib.Extensions;

namespace GroceryStoreSimulatorWebAPI.Models
{
    [Table("tOrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double TotalAmountChargedToCustomer { get; set; }
        public string? Comment { get; set; }
        public int? CouponDetailID { get; set; }
        public bool? UnavailableWhenOrderWasFilled { get; set; }
    }
}
