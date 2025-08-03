using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace SalesPrediction.Api.Models
{
    public class OrdersDetail
    {
        [Key]
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public Orders Order { get; set; }
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int qty { get; set; }
        public int Discount { get; set; }

    }
}
