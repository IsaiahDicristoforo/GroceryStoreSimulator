
using Dapper.Contrib.Extensions;

namespace GroceryStoreSimulatorWebAPI.Models
{
    [Table("tStore")]
    public class StoreModel
    {
        [Key]
        public int StoreId { get; set; }
        public string Store { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip {get; set; }
        public int ManagerId { get; set; }
        public string StoreNumber { get; set; }
        public bool IsVirtual { get; set; }
        public int CountryId;

    }
}
    