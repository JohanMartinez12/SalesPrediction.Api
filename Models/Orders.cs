using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SalesPrediction.Api.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public Customer CustomerId { get; set; }
        public int EmployeeId { get; set; } //fk
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShippedId { get; set; } //fk
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

    }
}
