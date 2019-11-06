namespace Jaroszek.ProofOfConcept.Infrastructure.Models
{
    using System.Collections.Generic;

    public class OrderDto
    {
        public string ContractorName { get; set; }
        public string Description { get; set; }
        private List<OrderItemsDto> OrderItemsesDto { get; set; }
    }
}