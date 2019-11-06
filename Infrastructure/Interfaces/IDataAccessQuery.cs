namespace Jaroszek.ProofOfConcept.Infrastructure.Interfaces
{
    using Jaroszek.ProofOfConcept.Infrastructure.Models;
    using System.Collections.Generic;

    public interface IDataAccessQuery
    {
        List<Order> GetAll();
        Order GetByContractorName(string contractorName);
        List<OrderItems> GetOrderItems(int id);
    }
}