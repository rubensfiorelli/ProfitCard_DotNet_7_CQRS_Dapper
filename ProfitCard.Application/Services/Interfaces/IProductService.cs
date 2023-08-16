using ProfitCard.Application.Input.InputModels;

namespace ProfitCard.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task AddAsync(ProductInputModel product);
        Task<bool> DeleteAsync(Guid id);

    }
}
