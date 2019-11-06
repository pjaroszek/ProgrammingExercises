using Jaroszek.ProofOfConcept.Infrastructure.Interfaces;
using Jaroszek.ProofOfConcept.Infrastructure.Models;

namespace Jaroszek.ProofOfConcept.SqlServer.Services
{
    public class OperationsRepositoryCommand : IDataAccessCommand
    {
        public void AddNew(OrderDto order)
        {
            throw new System.NotImplementedException();
        }

        public void Update(OrderDto order)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProdactByProdactCode(string prodactCode)
        {
            throw new System.NotImplementedException();
        }
    }
}