namespace SalesPrediction.Api.Models
{
    public class PredictionDTO
    {
        public string CustomerName { get; set; }
        public DateTime LastOrderDate { get; set; }
        public DateTime NextPredictedOrder { get; set; }
    }
}
