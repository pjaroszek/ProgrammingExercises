namespace Jaroszek.ProofOfConcept.Infrastructure.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public decimal Quantiti { get; set; }
        public decimal Price { get; set; }
    }
}