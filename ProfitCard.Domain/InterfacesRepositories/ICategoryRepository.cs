using ProfitCard.Domain.Entities;

namespace ProfitCard.Domain.InterfacesRepositories
{
    public interface ICategoryRepository : IUnitOfWork
    {
        void AddAsync(Category category);
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(Guid id);

    }
}
