using Dapper.Contrib.Extensions;

namespace GroceryStoreSimulatorWebAPI.Models
{
    [Table("tOrder")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int LoyaltyId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int StoreId { get; set; }
        public int OrderStatusId { get; set; }
        public double DeliveryCharge { get; set; }
        public string? Notes { get; set; }
        public string? DeliveryAddress { get; set; }
        public DateTime? DateTimeDelivered { get; set; }
        public bool? AllOrNone { get; set; }
    }
}
