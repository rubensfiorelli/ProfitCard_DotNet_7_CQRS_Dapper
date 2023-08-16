using ProfitCard.Domain.Entities;

namespace ProfitCard.Domain.InterfacesRepositories
{
    public interface IProductRepository : IUnitOfWork
    {
        Task AddAsync(Product product);
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid id);
        Task<bool> DeleteAsync(Guid id);

    }
}
