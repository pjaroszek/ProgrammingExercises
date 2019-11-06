namespace Jaroszek.ProofOfConcept.Infrastructure.Models
{
    public class OrderItemsDto
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public decimal Quantiti { get; set; }
    }
}