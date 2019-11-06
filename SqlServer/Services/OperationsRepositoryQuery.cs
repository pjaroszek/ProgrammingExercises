using Jaroszek.ProofOfConcept.Infrastructure.Interfaces;
using Jaroszek.ProofOfConcept.Infrastructure.Models;
using System.Collections.Generic;

namespace Jaroszek.ProofOfConcept.SqlServer.Services
{
    public class OperationsRepositoryQuery : IDataAccessQuery
    {
        public List<Order> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Order GetByContractorName(string contractorName)
        {
            throw new System.NotImplementedException();
        }

        public List<OrderItems> GetOrderItems(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}