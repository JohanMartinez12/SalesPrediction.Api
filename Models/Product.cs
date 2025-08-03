using System.ComponentModel.DataAnnotations;

namespace SalesPrediction.Api.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; } // Foreign key to Supplier
        public int CategoryId { get; set; } // Foreign key to Category   
        public int UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}