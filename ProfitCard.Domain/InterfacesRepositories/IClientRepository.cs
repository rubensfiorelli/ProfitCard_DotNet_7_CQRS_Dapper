using ProfitCard.Domain.Entities;

namespace ProfitCard.Domain.InterfacesRepositories
{
    public interface IClientRepository : IUnitOfWork
    {
        Task AddAsync(Client client);
        Task<List<Client>> GetAllAsync();
        Task<Client> GetByIdAsync(Guid id);
    }
}
