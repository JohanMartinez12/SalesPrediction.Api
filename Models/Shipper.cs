using System.ComponentModel.DataAnnotations;

namespace SalesPrediction.Api.Models
{
    public class Shipper
    {
        [Key]
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        // Navigation property for Orders
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
        
        // Constructor
        public Shipper()
        {
            Orders = new List<Orders>();
        }
    }
}