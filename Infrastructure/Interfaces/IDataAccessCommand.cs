using Jaroszek.ProofOfConcept.Infrastructure.Models;

namespace Jaroszek.ProofOfConcept.Infrastructure.Interfaces
{
    public interface IDataAccessCommand
    {
        void AddNew(OrderDto order);
        void Update(OrderDto order);
        void DeleteProdactByProdactCode(string prodactCode);
    }
}