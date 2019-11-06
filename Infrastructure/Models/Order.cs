namespace Jaroszek.ProofOfConcept.Infrastructure.Models
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }
        public string ContractorName { get; set; }
        public string ContractorAdress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        private List<OrderItems> OrderItemses { get; set; }
    }
}